using DomainLayer.Models;
using RepositoryLayer.Repositories;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly LibraryRepository repo;
        private int count;

        public LibraryService()
        {
            repo = new LibraryRepository();
        }

        public Library Create(Library library)
        {
            library.Id = count;
            repo.Add(library);
            count++;
            return library;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAll()
        {
            throw new NotImplementedException();
        }

        public Library GetById(int? id)

        {
            if (id is null) throw new ArgumentNullException();
            return repo.Get(m => m.Id == id);
        }

        public Library GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Library Update(int id, Library library)
        {
            throw new NotImplementedException();
        }
    }
}
