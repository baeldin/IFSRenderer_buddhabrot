﻿using IFSEngine.Utility;
using OpenTK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace IFSEngine.Animation;

public class Keyframe
{
    public string InterpolationMode { get; set; } = "Linear";
    public double EasingPower { get; set; } = 1.0;
    public EasingDirection EasingDirection { get; set; } = EasingDirection.InOut;
    public double t { get; set; }
    public double Value { get; set; }
    //public double LeftTangent;
    //public double RightTangent;
}
