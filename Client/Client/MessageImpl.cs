using System;

namespace Ch.Elca.Iiop.Demo.Chatroom {
	
    /// <summary>
    /// Implementation of the CORBA value type Message
    /// </summary>
    [Serializable]
    public class MessageImpl : Message {

        public MessageImpl() {
        }

        public MessageImpl(string originator, string msg) {
            //m_originator = originator;
            //m_msg = msg;
        }

        public string Originator {
            get {
                return "Originator";
            }
        }

        public string Msg {
            get {
                return "Msg";
            }
        }

	}
}
