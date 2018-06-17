using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式订阅者模式
{
    #region 抽象通知者
    /// <summary>
    /// 通知者
    /// </summary>
    interface IMessage_Kinds
        {/// <summary>
        /// 添加订阅者
        /// </summary>
        /// <param name="customer"></param>
            void Attach(Customer customer);
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="customer"></param>
            void Detach(Customer customer);
        /// <summary>
        /// 通知
        /// </summary>
            void Notify();
           
            string Message_kindsState
            {
                get;
                set;
            }
        }
    #endregion
    #region 抽象用户
    /// <summary>
    /// 抽象用户
    /// </summary>
    abstract class Customer
        {
        protected string name;
        protected IMessage_Kinds Kinds;

        public void SetKinds(IMessage_Kinds kinds)
        {
            Kinds.Detach(this);
            Kinds = kinds;
            kinds.Attach(this);
        }
        public Customer(string name, IMessage_Kinds Kinds)
            {
                this.name = name;
                this.Kinds = Kinds;
            }

            public abstract void Update();
        }

    #endregion
    #region 普通会员
    //普通会员
    class Membercustomer : Customer
        {
            public Membercustomer(string name, IMessage_Kinds Kinds)
                : base(name, Kinds)
            {
                Kinds.Attach(this); 
            }
            public override void Update()
            {
                Console.WriteLine("{0};普通会员{1}收到通知！", Kinds.Message_kindsState,name);
            }
        }
        #endregion

        #region  VIP会员
        class VIPcustomer : Customer
        {
            public VIPcustomer(string name, IMessage_Kinds Kinds) : base(name, Kinds)
            {
                 Kinds.Attach(this);
            }
            public override void Update()
            {
                Console.WriteLine("{0};VIP会员{1}收到通知！", Kinds.Message_kindsState, name);
            }
        }
        #endregion

        class Productname : IMessage_Kinds
        {
        /// <summary>
        /// 订阅者
        /// </summary>
            private IList<Customer> customers = new List<Customer>();
            private string action;
            public string name;
            public void Attach(Customer customer)
            {
                customers.Add(customer);
            }
            public void Detach(Customer customer)
            {
                customers.Remove(customer);
            }
            public void Notify()
            {
                foreach (Customer o in customers)
                    o.Update();
            }
            //名字信息
            public string Message_kindsState
            {
                get { return action; }
                set { action = value; }
            }
            //设置商品名
            public void Setname(string name)
            {
                this.name = name;
                Message_kindsState = "商品名已经更改为:" +name;
                Notify();
            }

        }


        class Productprice : IMessage_Kinds
        {
            //会员列表
            private IList<Customer> customers = new List<Customer>();
            private string action;
            public double price;
            //增加连接
            public void Attach(Customer customer)
            {
                customers.Add(customer);
            }
            //减少连接
            public void Detach(Customer customer)
            {
                customers.Remove(customer);
            }
            //通知消息
            public void Notify()
            {
                foreach (Customer o in customers)
                    o.Update();
            }
            //价格信息
            public string Message_kindsState
            {
                get { return action; }
                set { action = value; }
            }
            //设置价格
            public void setprice(double price)
            {
               this.price = price;
               Message_kindsState = "商品价格已经更改为:" + price;
               Notify();
            }

        }
    class Program
    {
        static void Main(string[] args)
        {

            Productname name = new Productname();

            Productprice price = new Productprice();


            //普通会员
            Membercustomer member1 = new Membercustomer("小明", name);
            //VIP会员
            VIPcustomer VIP1 = new VIPcustomer("阿伟", name);
            //普通会员
            Membercustomer member2 = new Membercustomer("大基佬", price);
            //VIP会员
            VIPcustomer VIP2 = new VIPcustomer("小狼", price);
            name.Setname("皮");
            price.setprice(5);
            VIP1.SetKinds(price);
            VIP2.SetKinds(name);
            name.Setname("皮肤");
            price.setprice(50);
            Console.Read();
        }
    }
}
