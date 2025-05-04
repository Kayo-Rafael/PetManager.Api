using Pet.Comunnication.Requests;
using Pet.Comunnication.Responses;

namespace Pet.Application.UseCases.Pets.Register;

public class RegisterPetUseCase
{
     public ResponseRegisterPetJson Execute(RequestPetJson request)
    {
        return new ResponseRegisterPetJson
        {
            Id = 1,
            Name = request.Name,
        };
    }
}
