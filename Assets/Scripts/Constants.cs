using System;
using System.Collections.Generic;

public class Constants
{
    public static float ANGLE_0 = 0;
    public static float ANGLE_90 = 90;
    public static float ANGLE_180 = 180;
    public static float ANGLE_270 = 270;


    public static Dictionary<BlockAngle, float> AngleDictionary = new Dictionary<BlockAngle, float>()
    {
        {BlockAngle.A0, ANGLE_0},
        {BlockAngle.A90, ANGLE_90},
        {BlockAngle.A180, ANGLE_180},
        {BlockAngle.A270, ANGLE_270}
    };
    
    
    public static Dictionary<BlockAngle, BlockAngle> AngleDictionaryNext = new Dictionary<BlockAngle, BlockAngle>()
    {
        {BlockAngle.A0, BlockAngle.A90},
        {BlockAngle.A90, BlockAngle.A180},
        {BlockAngle.A180, BlockAngle.A270},
        {BlockAngle.A270, BlockAngle.A0}
    };

    public class Tags
    {
        public static String BlockTypeA = "BlockTypeA";
        public static String BlockTypeB = "BlockTypeB";
    }
}