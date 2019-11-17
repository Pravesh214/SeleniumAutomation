using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.UltimateQa.Application.UltimateQa.Locator
{
    public class FormSubmissionLocators
    {
        public By Name => By.Id("et_pb_contact_name_0");

        public By Message => By.Id("et_pb_contact_message_0");

        public By Submit => By.XPath("//*[@id=\"et_pb_contact_form_0\"]/div[2]/form/div/button");
    }
}
