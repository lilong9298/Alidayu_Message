using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alidayu_Message.Model
{
    public class Model
    {
        /// <summary>
        /// API接口名称
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// TOP分配给应用的AppKey
        /// </summary>
        public string App_key { get; set; }

        /// <summary>
        /// 被调用的目标AppKey，仅当被调用的API为第三方ISV提供时有效。
        /// </summary>
        public string Target_app_key { get; set; }

        /// <summary>
        /// 签名算法
        /// </summary>
        public string Sign_method { get; set; }

        /// <summary>
        /// 签名结果
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// 用户登录授权成功后，TOP颁发给应用的授权信息，详细介绍请点击这里。当此API的标签上注明：“需要授权”，则此参数必传；“不需要授权”，则此参数不需要传；“可选授权”，则此参数为可选。
        /// </summary>
        public string Session { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public string Timestamp { get; set; }

        /// <summary>
        /// 响应格式
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// API协议版本，可选值：2.0。
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 合作伙伴身份标识
        /// </summary>
        public string Partner_id { get; set; }

        /// <summary>
        /// 是否采用精简JSON返回格式，仅当format=json时有效，默认值为：false。
        /// </summary>
        public string Simplify { get; set; }
    }
}
