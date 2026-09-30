using System;

namespace Builder;

public class AddressBuilder
{
    
    // mandatory
    public string Street { get;  }
    public string City { get;  }
    public string Country { get; }

   

    // optional

    public string State{get;set;}
    public string ZipCode{get;set;}

    


    public AddressBuilder(string street, string city, string country)
    {
        Street = street;
        City = city;
        Country = country;

    }

    public AddressBuilder SetState(string state)
    {
        State=state;
        return this;
    }
    public AddressBuilder SetZipCode(string zipcode)
    {
        ZipCode=zipcode;
        return this;
    }
   
    


}
