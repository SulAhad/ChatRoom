using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    class Message //
    {
        public int MessageId { get; set; } //Свойства для получения id 
        public string MessageText { get; set; } // свойтсво для получения текста

        //[DataType(DataType.DateTime)]
        public DateTime MessageDateTime { get; set; } //свойство для получения времени и даты

        public string MessageState { get; set; } // свойство для получения статуса о прочтении. Прочитано сообщение или нет

        public int UserSenderId { get; set; }// отправитель
        public virtual UserInfo UserSender { get; set; }//база данных должна подтягивать нужного нам user
        public int UserRecipientId { get; set; }// получатель
        public virtual UserInfo UserRecipient { get; set; }//база данных должна подтягивать нужного нам user
    }
}
