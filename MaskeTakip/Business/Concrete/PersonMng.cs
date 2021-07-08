using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonMng : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {

            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            TCKimlikNoDogrulaRequest xx =  new TCKimlikNoDogrulaRequest();
            xx.Body = new TCKimlikNoDogrulaRequestBody();
            xx.Body.Ad = person.FirstName;
            xx.Body.DogumYili = person.DateOfBirthYear;
            xx.Body.Soyad = person.LastName;
            xx.Body.TCKimlikNo = person.NationalIdentity;
            return client.TCKimlikNoDogrulaAsync(xx).Result.Body.TCKimlikNoDogrulaResult ;
        }
    }
}
