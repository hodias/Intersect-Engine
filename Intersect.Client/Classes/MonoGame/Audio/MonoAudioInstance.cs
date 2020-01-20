﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Intersect.Client.Framework.Audio;

using JetBrains.Annotations;

namespace Intersect.Client.MonoGame.Audio
{
    public abstract class MonoAudioInstance<TSource> : GameAudioInstance where TSource : GameAudioSource
    {

        /// <inheritdoc />
        protected MonoAudioInstance([NotNull] GameAudioSource source) : base(source)
        {
        }

        [NotNull] public new TSource Source => base.Source as TSource ?? throw new InvalidOperationException();

    }
}
