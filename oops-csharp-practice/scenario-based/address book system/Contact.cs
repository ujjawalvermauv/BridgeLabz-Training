using System;

public class Contact
{
    //uc1
    private string FirstName;
    private string SecondName;
    private string Address;
    private string City;
    private string State;
    private string PhoneNumber;
    private string Email;

    public void SetFirstName(string FirstName) 
    {
        this.FirstName=FirstName;
    }
    public GetFirstName(){
        return FirstName;
        
    }
    public void SetSecondName(string SecondName) 
    {
        this.SecondName=SecondName;
    }
    public GetLastName(){
        return LastName;
        
    }
    public void SetAddress(string Adress) 
    {
        this.Address=Address;
    }
    public GetAddress(){
        return Address;
        
    }
    public void SetCity(string City) 
    {
        this.City=City;
    }
    public GetCity(){
        return City;
        
    }
    public void SetState(string State) 
    {
        this.State=State;
    }
    public GetState(){
        return State;
        
    }
    public void SetPhoneNumber(string PhoneNumber) 
    {
        this.PhoneNumber=PhoneNumber;
    }
    public GetPhoneNumber(){
        return PhoneNumber;
        
    }
    public void SetEmail(string Email)
    {
        this.Email=Email;
        
    }
    public GetEmail()
    {
        return Email;
    }
    public AdressBook(string FirstName,string SecondName,string Address ,string City,string State,string PhoneNumber,string Email)
    {
        this.Address=Address;
        this.FirstName=Firstname;
        this.SecondName=SecondName;
        this.Address=Address;
        this.State=State;
        this.PhoneNumber=PhoneNumber;
        this.Email=Email;
        this.City=City;

    }
    public override string ToString()
        {
            return "FirstName" + this.FirstName +"LastName"+this.SecondName+"Address "+this.Address+"city"+this.City+"phoneNumber"+this.PhoneNumber+"Email"+this.Email;
        }
    
    

}