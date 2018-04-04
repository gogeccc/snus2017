using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Collections;

namespace sharedLib.alarm
{
    [ServiceContract]
    interface AlarmDisplayInterface
    {
        [OperationContract]
        ArrayList getNewAlarms();
    }
}
