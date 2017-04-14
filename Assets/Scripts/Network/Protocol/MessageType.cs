
namespace SimpleSync.Protocol
{
    public enum MessageType
    {
        MT_E2D_START = 1001,
        MT_E2D_SYNC_REQUEST = 1002,
        MT_E2D_START_SYNC = 1003,
        MT_E2D_STOP_SYNC = 1004,

        MT_D2E_SCENE_ID = 2001,
        MT_D2E_SCENE_CHANGED = 2002,
        MT_D2E_REQUEST_RESULT = 2003,
        MT_D2E_SYNC_UPDATE = 2004,
        
    }
}