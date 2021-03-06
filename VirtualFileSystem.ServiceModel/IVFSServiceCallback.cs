﻿using System.ServiceModel;

namespace VirtualFileSystem.ServiceModel
{

    internal interface IVFSServiceCallback
    {

        [OperationContract(IsOneWay = true)]
        void OnCommandPerformed(CommandPerformedData data);

    }

}
