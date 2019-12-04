using Microsoft.AspNetCore.Mvc;
using Test.Models;
using Services;



namespace Test.Controllers{


public abstract class BooksController<TModel>:ControllerBase
where TModel:Books
{

        public BaseMongoRepository<TModel> baseMongoRepository{get;set;}
        public BooksController(BaseMongoRepository<TModel> _bs)
        {
            this.baseMongoRepository=_bs;
        }
        [HttpGet("{id}")]
        public virtual ActionResult GetModel(string id)
        {
            return Ok(this.baseMongoRepository.GetById(id));
        }

        [HttpGet]
        public virtual ActionResult GetModelList()
        {
            return Ok(this.baseMongoRepository.GetList());
        }

        [HttpPost]
        public virtual ActionResult AddModel(TModel model)
        {
            return Ok(this.baseMongoRepository.Create(model));
        }

        [HttpPut]
        public virtual ActionResult UpdateModel(string id,TModel model)
        {
            this.baseMongoRepository.Update(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public virtual void DeleteModel(string id)
        {
            this.baseMongoRepository.Delete(id);
        }

    }



}