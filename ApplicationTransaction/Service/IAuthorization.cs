using AppTransaction.SharedModels;

namespace AppTransaction.Service;

public interface IAuthorization
{
    User[] Users { get; set; }
    bool Login(out User? user);
}
