public class PersonalInformation {
    private string _name = "";
    private string _address = "";
    private int _age = 0;
    private string _phoneNumber = "";

    public PersonalInformation(string name, string address, int age, string phoneNumber){
            _name = name;
            _address = address;
            _age = age;
            _phoneNumber = phoneNumber;
    }


    public string GetName(){
        return _name;
    }

    public string GetAddress(){
        return _address;
    }

    public int GetAge(){
        return _age;
    }

    public string GetPhoneNumber(){
        return _phoneNumber;
    }

    public void SetName(string name){
        name = _name;
    }

    public void SetAddress(string address){
        address = _address;
    }

    public void SetAge(int age){
        age = _age;
    }

    public void SetPhoneNumber(string phoneNumber){
        phoneNumber = _phoneNumber;
    }
}