﻿namespace Myvas.AspNetCore.Authentication
{
    public static class WeixinAuthDefaults
    {
        /// <summary>
        /// WeixinAuth
        /// </summary>
        public const string AuthenticationScheme = "WeixinAuth";

        /// <summary>
        /// WeixinAuth
        /// </summary>
        public const string DisplayName = "WeixinAuth";

        /// <summary>
        /// WeixinAuth
        /// </summary>
        public const string ClaimsIssuer = "WeixinAuth";

        /// <summary>
        /// /signin-weixinauth
        /// </summary>
        public const string CallbackPath = "/signin-weixinauth";
        
        /// <summary>
        /// https://open.weixin.qq.com/connect/oauth2/authorize, different from WeixinOpen
        /// </summary>
        public const string AuthorizationEndpoint = "https://open.weixin.qq.com/connect/oauth2/authorize";

        /// <summary>
        /// https://api.weixin.qq.com/sns/oauth2/access_token
        /// </summary>
        public const string TokenEndpoint = "https://api.weixin.qq.com/sns/oauth2/access_token";

        /// <summary>
        /// https://api.weixin.qq.com/sns/userinfo
        /// </summary>
        public const string UserInformationEndpoint = "https://api.weixin.qq.com/sns/userinfo";

        /// <summary>
        /// https://api.weixin.qq.com/sns/oauth2/refresh_token
        /// </summary>
        public const string RefreshTokenEndpoint = "https://api.weixin.qq.com/sns/oauth2/refresh_token";

        /// <summary>
        /// https://api.weixin.qq.com/sns/auth
        /// </summary>
        public const string ValidateTokenEndpoint = "https://api.weixin.qq.com/sns/auth";
    }
}
