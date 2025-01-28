using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;

namespace VisualScoreCounter.Utils
{
    internal static class XRUtil
    {
        public static bool IsPresent()
        {
            var xrDisplaySubsystems = new List<XRDisplaySubsystem>();
            SubsystemManager.GetInstances(xrDisplaySubsystems);
            return xrDisplaySubsystems.Any(xrDisplay => xrDisplay.running);
        }
    }
}
