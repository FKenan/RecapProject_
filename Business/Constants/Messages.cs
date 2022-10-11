using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string InvalidCarData = "Geçersiz Bilgi Girildi. Araba eklenemedi.";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarsListed = "Arabalar Listelendi";
        public static string RentalAdded;
        public static string RentalDeleted;
        public static string RentalUpdated;
        public static string UserAdded;
        public static string UserDeleted;
        public static string UserUpdated;
        public static string CustomerAdded;
        public static string CustomerDeleted;
        public static string CustomerUpdated;
        public static string CustomersListed;
        public static string RentalsListed;
        public static string UsersListed;
        public static string InvalidRental;
        public static string CarImageAdded;
        public static string CarImageDeleted;
        public static string CarImageUpdated;
        public static string CarImagesListed;
        public static string CarImageLimitExceded;
        public static string AuthorizationDenied;
        public static string AccessTokenCreated;
        public static string UserNotFound;
        public static string PasswordError;
        public static string SuccessfulLogin;
        public static string UserRegistered;
        public static string UserAlreadyExists;
    }
}
