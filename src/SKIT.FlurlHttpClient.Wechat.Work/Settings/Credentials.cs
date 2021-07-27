﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.Wechat.Work.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.CorpId"/> 的副本。
        /// </summary>
        public string CorpId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.AgentId"/> 的副本。
        /// </summary>
        public int? AgentId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.AgentSecret"/> 的副本。
        /// </summary>
        public string? AgentSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.ProviderSecret"/> 的副本。
        /// </summary>
        public string? ProviderSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.SuiteId"/> 的副本。
        /// </summary>
        public string? SuiteId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="WechatWorkClientOptions.SuiteId"/> 的副本。
        /// </summary>
        public string? SuiteSecret { get; }

        internal Credentials(WechatWorkClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            CorpId = options.CorpId;
            AgentId = options.AgentId;
            AgentSecret = options.AgentSecret;
            ProviderSecret = options.ProviderSecret;
            SuiteId = options.SuiteId;
            SuiteSecret = options.SuiteSecret;
        }
    }
}