using Core.Domain.Entity;
using Core.Extensions.Annotation;
using Domain.ScheduleHistory.Entities;
using Infrastructure.Exceptions;
using Quartz;
using System;
using System.Collections.Generic;

namespace Domain.Schedule.Entities
{
    public class ScheduleJob : AggregateRoot<JobKey>
    {
        private readonly JobKey _jobKey;

        public override JobKey Id { get => _jobKey; protected set => throw new NotImplementedException(); }

        public string JobName { get => _jobKey.Name; }

        public string GroupName { get => _jobKey.Group; }

        public JobStatus Status { get; protected set; }

        public string ExecutionStragtegyId { get; protected set; }

        internal string Table { get; }

        internal ScheduleJob(
            string groupName, 
            string jobName, 
            JobStatus status, 
            string table,
            string stragetegyId, 
            DateTime creationTime, 
            DateTime updateTime)
        {
            _jobKey = JobKey.Create(groupName, jobName);
            Status = status;
            ExecutionStragtegyId = stragetegyId;
            CreationTime = creationTime;
            UpdateTime = updateTime;
            Table = table;
        }

        public void Deconstruct(
            out string groupName, out string jobName, out int status, out string table,
            out string stragetegyId, out DateTime creationTime, out DateTime updateTime)
        {
            groupName = GroupName;
            jobName = JobName;
            stragetegyId = ExecutionStragtegyId;
            status = (int)Status;
            creationTime = CreationTime;
            updateTime = UpdateTime;
            table = Table;
        }

        public bool GetReady()
        {
            if (string.IsNullOrWhiteSpace(ExecutionStragtegyId)) return false;
            else
            {
                Status = JobStatus.Init;
                return true;
            }
        }

        public JobHistory CreateHistory(string name, string description)
        {
            return new JobHistory(name, description);
        }

        public void SetExecutionStragtegy(ExecutionStrategy stragtegy)
        {
            ExecutionStragtegyId = (stragtegy ?? throw new ArgumentNullException(nameof(stragtegy))).Id;
        }

        /// <summary>
        /// 用户手动触发开始任务
        /// </summary>
        /// <param name="message">执行操作后的消息提示</param>
        /// <returns>操作结果</returns>
        public bool Start(out string message)
        {
            message = string.Empty;
            var result = false;

            switch (Status)
            {
                case JobStatus.Init:
                case JobStatus.Stopped:
                    Status = JobStatus.Scheduling;
                    result = true;
                    message = "任务已经入调度状态";
                    break;

                case JobStatus.Running:
                    message = "任务正在运行中";
                    break;
                case JobStatus.Scheduling:
                    message = "任务已经入调度状态";
                    break;   
                default:
                    break;
            }

            return result;
        }

        /// <summary>
        /// 手动停止任务
        /// </summary>
        /// <param name="message">执行操作后的提示信息</param>
        /// <returns>操作结果</returns>
        public bool Stop(out string message)
        {
            var result = false;
            message = string.Empty;

            switch (Status)
            {
                case JobStatus.Init:
                    message = "任务还没开始运行";
                    break;
                case JobStatus.Running:
                    message = "任务正在运行中。稍后会自动停止";
                    break;
                case JobStatus.Scheduling:
                    message = "停止任务成功";
                    result = true;
                    break;
                case JobStatus.Stopped:
                    message = "任务已经停止";
                    break;
                default:
                    break;
            }

            return result;
        }

        /// <summary>
        /// 触发器启动后，任务开始执行从调度状态变为运行状态
        /// </summary>
        internal void Run()
        {
            if (Status == JobStatus.Scheduling || Status == JobStatus.Init)
            {
                Status = JobStatus.Running;
            }
            else
            {
                throw new JobStatusException(Status.GetDescription(), JobStatus.Running.GetDescription());
            }
        }

        /// <summary>
        /// 触发器启动后，任务执行完毕从运行状态变为调度状态
        /// </summary>
        internal void Scheduling()
        {
            if (Status == JobStatus.Running) Status = JobStatus.Scheduling;
            else throw new JobStatusException(Status.GetDescription(), JobStatus.Scheduling.GetDescription());
        }
    }
}
