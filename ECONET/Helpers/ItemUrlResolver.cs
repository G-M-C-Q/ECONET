using AutoMapper;
using Core.Entities;
using ECONET.DTO;

namespace ECONET.Helpers
{
    public class ItemUrlResolver : IValueResolver<Item, ItemToReturnDto, String>
    {
        private readonly IConfiguration _config;
        public ItemUrlResolver(IConfiguration config)
        {
            _config = config;   
        }
        public string Resolve(Item source, ItemToReturnDto destination, string destMember, ResolutionContext context)
        {  ///Check if image url is empty or not
            if(!string.IsNullOrEmpty(source.PictureUrl))
            {
                //Property accessor
                return _config["ApiUrl"] + source.PictureUrl;
            }

            return null;
        }
    }


}