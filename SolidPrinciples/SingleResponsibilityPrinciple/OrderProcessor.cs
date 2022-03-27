using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class OrderProcessor
    {

        string orderValue;
        private readonly static OrderValidator orderValidator;
        private readonly static OrderSaver orderSaver;
        private readonly static OrderNotificationSender orderNotificationSender;
        static OrderProcessor()
        {
            orderValidator = new OrderValidator();
            orderSaver = new OrderSaver();
            orderNotificationSender = new OrderNotificationSender();
        }
        public OrderProcessor(string orderValue)
        {
            this.orderValue = orderValue;
        }
        public void Process()
        {
            orderValidator.Validate(orderValue);
            orderSaver.Save(orderValue);
            orderNotificationSender.SendNotification(orderValue);

        }
    }
}
