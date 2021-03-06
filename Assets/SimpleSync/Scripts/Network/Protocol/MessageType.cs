
namespace SimpleSync.Protocol
{
    public enum MessageType
    {
        MT_E2D_START = 1001,            //Editor tell device to start sync to get scene id
        MT_E2D_SYNC_REQUEST = 1002,     //Editor request sync objects list
        MT_E2D_START_SYNC = 1003,       //Editor tell device to start sending back sync data
        MT_E2D_STOP_SYNC = 1004,        //Editor tell device to stop sending sync data
        MT_E2D_CONTROL_REQUEST = 1005,  //Editor request control objects list
        MT_E2D_CONTROL_UPDATE = 1006,   //Editor send control data every frame after MT_D2E_CONTROL_RESPOND
        MT_E2D_STOP_CONTROL = 1007,     //Editor tell device to stop control
        MT_E2D_UPDATE_SYNC_RATE = 1008, //Editor update the sync frame rate

        MT_D2E_SCENE_ID = 2001,         //Respond to MT_E2D_START
        MT_D2E_SCENE_CHANGED = 2002,    //Tell editor the device change scene
        MT_D2E_SYNC_RESPOND = 2003,     //Respond to MT_E2D_SYNC_REQUEST with a count how manay objects that will be sync
        MT_D2E_SYNC_UPDATE = 2004,      //After MT_D2E_REQUEST_RESULT, send sync data every frame
        MT_D2E_CONTROL_RESPOND = 2005,  //Respond to MT_E2D_CONTROL_REQUEST with a list of objects can be controlled

    }
}