using System;
Using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Business_Rules_Engine_Console
{
    [TestClass]
    public class Unit_Test_Business_Rules_Engine
    {

        [TestMethod]
        public void Bus_rules_Engine_Should_Generate_PackagingSlip_For_PhysicalProduct()
        {
            //Arrange
            int physicalProduct = PaymentType.PhysicalProduct.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(physicalProduct);
            //Act
            bool result = paymentObject.ProcessPayment();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Bus_rules_Engine_Create_Duplicate_File()
        {
            //Arrange
            int book = PaymentType.Book.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(book);
            //Act
            bool result = paymentObject.ProcessPayment();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Bus_rules_Engine_ActivateMembership()
        {
            //Arrange
            int activate = PaymentType.MembershipActivate.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(activate);
            //Act
            bool result = paymentObject.ProcessPayment();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Bus_rules_Engine_Should_Upgrade_Membership()
        {
            //Arrange
            int upgrade = PaymentType.MembershipUpgrade.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(upgrade);
            //Act
            bool result = paymentObject.ProcessPayment();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Bus_rules_Engine_Should_Generate_FreeVideoSlip()
        {
            //Arrange
            int video = PaymentType.Video.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(video);
            //Act
            bool result = paymentObject.ProcessPayment();
            //Assert
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Bus_rules_Engine_Commission_Pymnt_For_Book_Physical_Product()
        {
            //Arrange
            int video = PaymentType.Video.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(video);
            //Act
            bool result = paymentObject.ProcessPayment();
            //Assert
            Assert.AreEqual(result, true);
        }
        public void Bus_rules_Engine_Send_Email_Membership_Activation_Upgrade()
        {
            //Arrange
            int video = PaymentType.Video.GetHashCode();
            IPayment paymentObject = PaymentFactory.GetPaymentObject(video);
            //Act
            bool result = paymentObject.ProcessPayment();
            //Assert
            Assert.AreEqual(result, true);
        }

    }
}
