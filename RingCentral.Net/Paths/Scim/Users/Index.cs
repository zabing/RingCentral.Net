using System.Threading.Tasks;

namespace RingCentral.Paths.Scim.Users
{
    public partial class Index
    {
        public RestClient rc;
        public string id;
        public Scim.Index parent;

        public Index(Scim.Index parent, string id = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.id = id;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && id != null)
            {
                return $"{parent.Path()}/Users/{id}";
            }

            return $"{parent.Path()}/Users";
        }

        // Operation: searchViaGet2
        public async Task<RingCentral.UserSearchResponse> List(SearchViaGet2Parameters queryParams = null)
        {
            return await rc.Get<RingCentral.UserSearchResponse>(this.Path(false), queryParams);
        }

        // Operation: createUser2
        public async Task<RingCentral.UserResponse> Post(RingCentral.User user)
        {
            return await rc.Post<RingCentral.UserResponse>(this.Path(false), user);
        }

        // Operation: getUser2
        public async Task<RingCentral.UserResponse> Get()
        {
            if (this.id == null)
            {
                throw new System.ArgumentNullException("id");
            }

            return await rc.Get<RingCentral.UserResponse>(this.Path());
        }

        // Operation: replaceUser2
        public async Task<RingCentral.UserResponse> Put(RingCentral.User user)
        {
            if (this.id == null)
            {
                throw new System.ArgumentNullException("id");
            }

            return await rc.Put<RingCentral.UserResponse>(this.Path(), user);
        }

        // Operation: deleteUser2
        public async Task<string> Delete()
        {
            if (this.id == null)
            {
                throw new System.ArgumentNullException("id");
            }

            return await rc.Delete<string>(this.Path());
        }

        // Operation: patchUser2
        public async Task<RingCentral.UserResponse> Patch(RingCentral.UserPatch userPatch)
        {
            if (this.id == null)
            {
                throw new System.ArgumentNullException("id");
            }

            return await rc.Patch<RingCentral.UserResponse>(this.Path(), userPatch);
        }
    }
}

namespace RingCentral.Paths.Scim
{
    public partial class Index
    {
        public Scim.Users.Index Users(string id = null)
        {
            return new Scim.Users.Index(this, id);
        }
    }
}