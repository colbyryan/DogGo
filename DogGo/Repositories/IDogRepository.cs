﻿using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        void AddDog(Dog dog);
        void DeleteDog(int dogId);
        List<Dog> GetAllDogs();
        Dog GetDogsById(int id);
        void UpdateDog(Dog dog);
        List<Dog> GetDogsByOwnerId(int ownerId);
    }
}