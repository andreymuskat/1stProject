﻿using _1stProject.TgButtonsLogic;
using Telegram.Bot.Types;


namespace _1stProject.States
{
    public class CreateCompany : IState
    {
        Storage _storage1 = new Storage();
        Company _company;
        //проверка существует ли компания
        //сделать первого юзера админом
        public ModelOfMessage HandleUpdate(Update update, UserController controller)
        {
            ModelOfMessage message= MessagesFromTg.ShowMenuForCreatingNewCompany;
            
            bool exists = IsThisCompanyAlreadyExist(update);
            if (exists == false)
            {
                //_storage1.AddNewCompany(_company.IdCompany, _company.NameCompany);
                controller.State = new AddNewCompanyState();
                message = MessagesFromTg.GreatCompany;
            }
              return message;
        }

        public bool IsThisCompanyAlreadyExist(Update update)
        {
            bool answer =_storage1.AllCompany.ContainsValue(update.Message.Text);
            return answer;
        }
    }
}
