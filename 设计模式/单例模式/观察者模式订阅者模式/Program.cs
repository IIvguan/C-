using System;
using System.Collections.Generic;

namespace 观察者模式订阅者模式
{
    /// <summary>
    /// 行为抽象
    /// </summary>
    public abstract class IMessage_Kinds
    {
        protected IList<IMessage_Kinds> customers = new List<IMessage_Kinds>();
        protected int Id { get; set; }//id
        protected string Name { get; set; }//name
        protected string Message_kindsState;//message

        public string GetMessage()
        {
            return Message_kindsState;
        }
        public void SetMessage(string srting)
        {
            Message_kindsState = srting;
        }

        /// <summary>
        /// 添加订阅者
        /// </summary>
        /// <param name="customer"></param>
        public void Attach(IMessage_Kinds message_Kinds)
        {
            customers.Add(message_Kinds);
        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="customer"></param>
        public void Detach(IMessage_Kinds message_Kinds)
        {
            customers.Add(message_Kinds);
        }
        /// <summary>
        /// 通知
        /// </summary>
        public abstract void Notify();
        /// <summary>
        /// 通知信息改变
        /// </summary>
        public abstract void Update(MesssageBW messsageBW);
    }

    public class MesssageBW
    {
        private IMessage_Kinds _orgin;
        private IMessage_Kinds _aims;

        public MesssageBW(IMessage_Kinds orgin, IMessage_Kinds aims)
        {
            _orgin = orgin;
            _aims = aims;
        }
        public IMessage_Kinds GetOrgin()
        {
            return _orgin;
        }
    }
    interface IAction
    {
        void SetAction(object ob);
    }
    #region 抽象用户
    /// <summary>
    /// 抽象用户
    /// </summary>
    abstract class Customer:IMessage_Kinds
    {
        public void AddKinds(IMessage_Kinds kinds)
        {
            this.Attach(kinds);
            kinds.Attach(this);
            //message
            SetMessage(Id+":"+Name + "订阅了你！");
            kinds.Update(new MesssageBW(this,kinds));
        }
        public void DelKinds(IMessage_Kinds kinds)
        {
            this.Detach(kinds);
            kinds.Detach(kinds);
            SetMessage(Id+":"+Name + "取消了订阅！");
            kinds.Update(new MesssageBW(this,kinds));
        }
        public Customer(int id,string _name,params IMessage_Kinds[] messages)
        {
            Id = id;
            Name = _name;
            foreach (IMessage_Kinds kind in messages)
            {
                AddKinds(kind);
            }
        }

    }

    #endregion
    #region 普通会员
    //普通会员
    class Membercustomer : Customer
    {
        public Membercustomer(int id, string name, params IMessage_Kinds[] kinds)
            : base(id,name, kinds)
        {

        }

        public override void Notify()
        {
            //pass
        }

        public override void Update(MesssageBW messsage)
        {
            Console.WriteLine("{0};普通会员{1}收到通知！", messsage.GetOrgin().GetMessage(), Name);
        }
    }
    #endregion

    #region  VIP会员
    class VIPcustomer : Customer
    {
        public VIPcustomer(int id,string name, params IMessage_Kinds[] kinds) : base(id,name,kinds)
        {
        }

        public override void Notify()
        {
           //pass
        }

        public override void Update(MesssageBW messsage)
        {
            Console.WriteLine("{0};VIP会员{1}收到通知！", messsage.GetOrgin().GetMessage(), Name);
        }
    }
    #endregion

     abstract  class Product : IMessage_Kinds,IAction
    {
        public Product(int _id,string _name,string _action)
        {
            Id = _id;
            Name = _name;
            Action = _action;
        }

        protected string Action { get; set; }

        public override void Notify()
        {
            foreach (Customer o in customers)
                o.Update(new MesssageBW(this,o));
        }

        public abstract void SetAction(object ob);
    }


    class Productprice : Product
    {
         public  Productprice(int _id,string _name,string _action) : base(_id, _name, _action)
        {
        }
         private  double _price;

        //设置价格
        public  override void  SetAction(object ob)
        {
            _price = Convert.ToDouble(ob);
            Message_kindsState = "商品价格已经更改为:" + _price;
            Notify();
        }

        public override void Update(MesssageBW messsageBW)
        {
            Console.WriteLine("{0};{1}收到通知！", messsageBW.GetOrgin().GetMessage(), Name);
        }
    }
    class Productname : Product
    {
        public Productname(int _id, string _name, string _action) : base(_id, _name, _action)
        {
        }
        private double _name;

        //设置价格
        public override void SetAction(object ob)
        {
            _name = Convert.ToDouble(ob);
            Message_kindsState = "商品名字已经更改为:" + _name;
            Notify();
        }

        public override void Update(MesssageBW messsageBW)
        {
            Console.WriteLine("{0};{1}收到通知！", messsageBW.GetOrgin().GetMessage(), Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product kinds = new Productprice(1, "人民日报", "price");
            IMessage_Kinds VP1 = new VIPcustomer(01, "小明", kinds);
            IMessage_Kinds men1 = new Membercustomer(02, "大基佬", kinds);
            kinds.SetAction(11.2);
            Console.Read();
        }
    }
}
