using AutoMapper;
using PlatformService.DTOs;
using PlatformService.Models;
using PlatformService.Repos.Contracts;
using PlatformService.Services.Contracts;
using System.Threading.Tasks;

namespace PlatformService.Services.Services
{
    public class UserService : IUserService
    {
        private IMapper _mapper;
        private IImageProcessorService _imageProcessor;
        private IUserRepo _userRepo;

        public UserService(IMapper imapper, IImageProcessorService imageProcessorService, IUserRepo userRepo)
        {
            _mapper = imapper;
            _imageProcessor = imageProcessorService;
            _userRepo = userRepo;
        }
        public async Task<ReadUserDTO> CreateUserAsync(CreateUserDTO createUserDTO)
        {
            var user = _mapper.Map<User>(createUserDTO);

            user.nationalIdback = await _imageProcessor.SaveImage(createUserDTO.nationalIdFront);
            user.nationalIdfront = await _imageProcessor.SaveImage(createUserDTO.nationalIdBack);
            user.selfie = await _imageProcessor.SaveImage(createUserDTO.selfie);
            user.profileImage = await _imageProcessor.SaveImage(createUserDTO.profileImage);
            user.utilityBill = await _imageProcessor.SaveImage(createUserDTO.utilityBill);

            var createdUser = await _userRepo.CreateUserAsync(user);

            return  _mapper.Map<ReadUserDTO>(createdUser);

        }

        public async Task<ReadUserDTO> UpdateUserAsync(UpdateUserDTO updateUserDTO)
        {
            var user = _mapper.Map<User>(updateUserDTO);

            user.nationalIdback = await _imageProcessor.SaveImage(updateUserDTO.nationalIdFront);
            user.nationalIdfront = await _imageProcessor.SaveImage(updateUserDTO.nationalIdBack);
            user.selfie = await _imageProcessor.SaveImage(updateUserDTO.selfie);
            user.profileImage = await _imageProcessor.SaveImage(updateUserDTO.profileImage);
            user.utilityBill = await _imageProcessor.SaveImage(updateUserDTO.utilityBill);

            var createdUser = await _userRepo.UpdateUserAsync(user);

            return _mapper.Map<ReadUserDTO>(createdUser);

        }

        public async Task<ReadUserDTO> GetUserByIdAsync(int id)
        {
            var userInDB = await _userRepo.GetUserAsync(id);

            return _mapper.Map<ReadUserDTO>(userInDB);
        }

        public async Task<int> DeleteUserAsync(int id)
        {
            return await _userRepo.DeleteUserAsync(id);
        }

    }
}
