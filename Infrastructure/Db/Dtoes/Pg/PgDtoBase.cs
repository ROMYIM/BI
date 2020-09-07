﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    public class PgDtoBase
    {
        private DateTime _utcCreateTime;

        /// <summary>
        /// 创建时间(UTC)
        /// </summary>
        public DateTime UtcCreateTime
        {
            get => _utcCreateTime == default ? (_utcCreateTime = DateTime.UtcNow) : _utcCreateTime;
            set => _utcCreateTime = value;
        }

        private DateTime _utcModifyTime;

        /// <summary>
        /// 修改时间(UTC)
        /// </summary>
        public DateTime UtcModifyTime
        {
            get => _utcModifyTime == default ? (_utcModifyTime = DateTime.UtcNow) : _utcModifyTime;
            set => _utcModifyTime = value;
        }

        private DateTime _utcCancelTime;
        /// <summary>
        /// 作废时间(UTC)
        /// </summary>
        public DateTime? UtcCancelTime
        {
            get => _utcCancelTime;
            set => _utcCancelTime = value ?? new DateTime(2001, 1, 1).ToUniversalTime();
        }
    }
}