using ACAutomationTesting.PageObjects.UpdateInfoPage.InputData;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Authors: Dima Raul Andrei
/// </summary>
namespace ACAutomationTesting.PageObjects.UpdateInfoPage
{
    public class UpdateProfilePage
    {
        private IWebDriver driver;
        public UpdateProfilePage(IWebDriver browser)
        {
            driver = browser;
        }

        private By Nume = By.CssSelector("input[name='full_name']");
        public IWebElement TxtNume => driver.FindElement(Nume);
        
        private By Telefon = By.CssSelector("input[name='telephone']");
        public IWebElement TxtTelefon => driver.FindElement(Telefon);
        
        private By OldPass = By.CssSelector("input[name='old_password']");
        public IWebElement TxtOldPass => driver.FindElement(OldPass);

        private By NewPass = By.CssSelector("input[name='new_password']");
        public IWebElement TxtNewPass => driver.FindElement(NewPass);

        private By ConfirmPass = By.CssSelector("input[name='confirm_password']");
        public IWebElement TxtConfirmPass => driver.FindElement(ConfirmPass);

        private By SalveazaDatele = By.CssSelector("form[name='myDataFrm'] > button");
        public IWebElement BtnSalveazaDatele => driver.FindElement(SalveazaDatele);

        private By SchimbaParola = By.CssSelector("form[name='securityFrm'] > button");
        public IWebElement BtnSchimbaParola => driver.FindElement(SchimbaParola);

        public By ParolaSchimbata = By.CssSelector("md-dialog[role='alertdialog'] md-dialog-content div> p");
        public IWebElement AlertParolaSchimbata => driver.FindElement(ParolaSchimbata);

	public By SalveazaDateleButonInactiv = By.CssSelector("form[name='myDataFrm'] > button[disabled='disabled']");



        // Melinte Alexandru-Gicu
        public By DataNasterii = By.Id("input_7");
        public IWebElement TxtDataNasterii => driver.FindElement(DataNasterii);

        public By AddAddressButton = By.CssSelector("#tab-content-1 > div > div > div.personal-data__address > h3 > button > span");
        public IWebElement BtnSchimbaAdresa => driver.FindElement(AddAddressButton);

        public void SaveInfo(NewInfoBo inputData)
        {
            TxtNume.Clear();
            TxtTelefon.Clear();
            TxtDataNasterii.Clear();
            TxtNume.SendKeys(inputData.Nume);
            TxtTelefon.SendKeys(inputData.Telefon);
            TxtDataNasterii.SendKeys(inputData.DataNasterii);
            BtnSalveazaDatele.Click();
        }

        public void ChangePass(NewInfoBo inputData)
        {
            TxtOldPass.SendKeys(inputData.OldPass);
            TxtNewPass.SendKeys(inputData.NewPass);
            TxtConfirmPass.SendKeys(inputData.ConfirmPass);
            BtnSchimbaParola.Click();
        }
    }
}
