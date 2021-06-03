﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.poi_check_notify 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/WeChat_Stores/WeChat_Store_Interface.html#8 </para>
    /// </summary>
    public class POICheckNotifyEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置商户门店 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("UniqId")]
        public string? SID { get; set; }

        /// <summary>
        /// 获取或设置门店 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("PoiId")]
        public string POIId { get; set; } = default!;

        /// <summary>
        /// 获取或设置审核结果。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Result")]
        public string Result { get; set; } = default!;

        /// <summary>
        /// 获取或设置审核信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("msg")]
        public string ResultMessage { get; set; } = default!;
    }
}