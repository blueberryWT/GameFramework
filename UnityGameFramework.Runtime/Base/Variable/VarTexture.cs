﻿//------------------------------------------------------------
// Game Framework v2.x
// Copyright © 2014-2016 Jiang Yin. All rights reserved.
// Homepage: http://gameframework.cn/
// Feedback: mailto:jiangyin@gameframework.cn
//------------------------------------------------------------

using GameFramework;
using UnityEngine;

namespace UnityGameFramework.Runtime
{
    /// <summary>
    /// Texture 变量类。
    /// </summary>
    public class VarTexture : Variable<Texture>
    {
        /// <summary>
        /// 初始化 Texture 变量类的新实例。
        /// </summary>
        public VarTexture()
        {

        }

        /// <summary>
        /// 初始化 Texture 变量类的新实例。
        /// </summary>
        /// <param name="value">值。</param>
        public VarTexture(Texture value)
            : base(value)
        {

        }

        /// <summary>
        /// 从 Texture 到 Texture 变量类的隐式转换。
        /// </summary>
        /// <param name="value">值。</param>
        public static implicit operator VarTexture(Texture value)
        {
            return new VarTexture(value);
        }

        /// <summary>
        /// 从 Texture 变量类到 Texture 的隐式转换。
        /// </summary>
        /// <param name="value">值。</param>
        public static implicit operator Texture(VarTexture value)
        {
            return value.Value;
        }
    }
}