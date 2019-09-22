using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.TestConstraint
{
    public interface IMessage
    {
        void SendMessage();
    }

    class Sms : IMessage
    {
        public void SendMessage()
        {
            throw new NotImplementedException();
        }
    }
    class EMail : IMessage
    {
        public void SendMessage()
        {
            throw new NotImplementedException();
        }
    }

    // انواع شرط گذاري
    //where T:struct
    //where T:class
    //where T:interface
    //where T:Ifoo
    //where T:Foo
    //where T:new()
    //where T1:T2

    public class MessageSender<T,T2> //-- where T : IMessage
    {
        public void SendAllMessages(List<T> message)
        {
            foreach (var item in message)
            {
                //if (item is IMessage)
                //{
                //    var msg = item as IMessage;
                //    msg.SendMessage();
                //}

                //item.SendMessage();
            }
        }
    }

    // ارث بري genericها
    public class Message2<T,T2>:MessageSender<T,T2>
    {

    }

    public class Message3<T, T2> : MessageSender<T, string>
    {

    }

    public class Message4 : MessageSender<int, string>
    {

    }

    public class TestConstraints
    {
    }
    public class MessageSenderTest
    {
        public MessageSenderTest()
        {
            //MessageSender<EMail> imsg = new MessageSender<EMail>();
            //imsg.SendAllMessages(new List<EMail>());
        }
    }
}
