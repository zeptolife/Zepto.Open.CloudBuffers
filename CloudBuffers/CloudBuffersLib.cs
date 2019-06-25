using System;

namespace CloudBuffers
{
    public class CloudBuffersLib
    {
        //Init Prism Container

        //Load BinaryBlob Module which implements IBinaryBlob

        //Load NoSQL Module which implemnets INoSQL

        //Load Provisioning Module which implements IProvisionable (GetCredential, isProvisioned, DoProvision)

        //Source sync concept GRPC is source module, BinaryBlob, NoSQL, Provisioning "sink modules"
        //As in, GRPC could also just be a module in the container which gets wired into the other modules

        // IIotProvisionable : IProvisionable
        //More functions surrounding IoTHubs in Azure

        //Start GRPC (Overload all GRPC methods)

        //Run
    }
}
