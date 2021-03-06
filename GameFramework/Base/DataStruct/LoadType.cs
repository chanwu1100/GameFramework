﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

namespace GameFramework
{
    /// <summary>
    /// 加载方式。
    /// </summary>
    public enum LoadType : byte
    {
        /// <summary>
        /// 按文本加载。
        /// </summary>
        Text = 0,

        /// <summary>
        /// 按二进制流加载。
        /// </summary>
        Bytes,

        /// <summary>
        /// 按二进制流加载。
        /// </summary>
        Stream
    }
}
