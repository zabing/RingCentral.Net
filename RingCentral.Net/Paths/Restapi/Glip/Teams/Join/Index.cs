using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Teams.Join
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Teams.Index parent;

        public Index(Restapi.Glip.Teams.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/join";
        }

        // Operation: joinGlipTeam
        public async Task<string> Post()
        {
            return await rc.Post<string>(this.Path());
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Restapi.Glip.Teams.Join.Index Join()
        {
            return new Restapi.Glip.Teams.Join.Index(this);
        }
    }
}