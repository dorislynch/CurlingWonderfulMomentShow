using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Curling.Wonderful.Moment.Show.RNCurlingWonderfulMomentShow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCurlingWonderfulMomentShowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCurlingWonderfulMomentShowModule"/>.
        /// </summary>
        internal RNCurlingWonderfulMomentShowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCurlingWonderfulMomentShow";
            }
        }
    }
}
