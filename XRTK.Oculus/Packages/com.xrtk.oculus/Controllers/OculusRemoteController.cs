﻿// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Definitions.Devices;
using XRTK.Definitions.Utilities;
using XRTK.Interfaces.InputSystem;

namespace XRTK.Oculus.Controllers
{
    public class OculusRemoteController : BaseOculusController
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="trackingState"></param>
        /// <param name="controllerHandedness"></param>
        /// <param name="inputSource"></param>
        /// <param name="interactions"></param>
        public OculusRemoteController(
            TrackingState trackingState,
            Handedness controllerHandedness,
            IMixedRealityInputSource inputSource = null,
            MixedRealityInteractionMapping[] interactions = null)
                : base(trackingState, controllerHandedness, OculusApi.Controller.None, OculusApi.Node.None, inputSource, interactions)
        {
        }

        /// <inheritdoc />
        public override MixedRealityInteractionMapping[] DefaultInteractions => new[]
        {
            new MixedRealityInteractionMapping(0, "Button.DpadUp", AxisType.Digital, "DpadUp", DeviceInputType.ButtonPress),
            new MixedRealityInteractionMapping(1, "Button.DpadDown", AxisType.Digital, "DpadDown", DeviceInputType.ButtonPress),
            new MixedRealityInteractionMapping(2, "Button.DpadLeft", AxisType.Digital, "DpadLeft", DeviceInputType.ButtonPress),
            new MixedRealityInteractionMapping(3, "Button.DpadRight", AxisType.Digital, "DpadRight", DeviceInputType.ButtonPress),
            new MixedRealityInteractionMapping(4, "Button.One", AxisType.Digital, "One", DeviceInputType.ButtonPress),
            new MixedRealityInteractionMapping(5, "Button.Two", AxisType.Digital, "Two", DeviceInputType.ButtonPress),
            new MixedRealityInteractionMapping(6, "Button.Start", AxisType.Digital, "Start", DeviceInputType.ButtonPress),
            new MixedRealityInteractionMapping(7, "Button.Back", AxisType.Digital, "Back", DeviceInputType.ButtonPress),
        };

        /// <inheritdoc />
        public override void SetupDefaultInteractions(Handedness controllerHandedness)
        {
            AssignControllerMappings(DefaultInteractions);
        }
    }
}