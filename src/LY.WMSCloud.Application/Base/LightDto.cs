using System;
using System.Collections.Generic;
using System.Text;

namespace LY.WMSCloud.Base
{
    public class StorageLight
    {
        public int MainBoardId { get; set; }
        public int RackPositionId { get; set; }
        public int lightOrder { get; set; }
        public int ContinuedTime { get; set; }
    }

    public class HouseLight
    {
        public int MainBoardId { get; set; }
        public int HouseLightSide { get; set; }
        public int lightOrder { get; set; }
    }

    public class AllLight
    {
        public int MainBoardId { get; set; }
        public int lightOrder { get; set; }
    }

    public class LightMsg
    {
        public bool IsOK { get; set; }
        public string Msg { get; set; }
    }
}
