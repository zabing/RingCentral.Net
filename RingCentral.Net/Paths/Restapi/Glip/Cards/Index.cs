using System.Threading.Tasks;
using System.Threading;

namespace RingCentral.Paths.Restapi.Glip.Cards
{
    public partial class Index
    {
        public RestClient rc;
        public string cardId;
        public Restapi.Glip.Index parent;

        public Index(Restapi.Glip.Index parent, string cardId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.cardId = cardId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && cardId != null)
            {
                return $"{parent.Path()}/cards/{cardId}";
            }

            return $"{parent.Path()}/cards";
        }

        /// <summary>
        /// Operation: Create Card
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/cards
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipMessageAttachmentInfo> Post(
            RingCentral.GlipMessageAttachmentInfoRequest glipMessageAttachmentInfoRequest,
            CreateGlipCardParameters queryParams = null, CancellationToken? cancellationToken = null)
        {
            return await rc.Post<RingCentral.GlipMessageAttachmentInfo>(this.Path(false),
                glipMessageAttachmentInfoRequest, queryParams, cancellationToken);
        }

        /// <summary>
        /// Operation: Get Card
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/glip/cards/{cardId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<RingCentral.GlipMessageAttachmentInfo> Get(CancellationToken? cancellationToken = null)
        {
            if (this.cardId == null)
            {
                throw new System.ArgumentNullException("cardId");
            }

            return await rc.Get<RingCentral.GlipMessageAttachmentInfo>(this.Path(), null, cancellationToken);
        }

        /// <summary>
        /// Operation: Update Card
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/glip/cards/{cardId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Put(RingCentral.GlipMessageAttachmentInfoRequest glipMessageAttachmentInfoRequest,
            CancellationToken? cancellationToken = null)
        {
            if (this.cardId == null)
            {
                throw new System.ArgumentNullException("cardId");
            }

            return await rc.Put<string>(this.Path(), glipMessageAttachmentInfoRequest, null, cancellationToken);
        }

        /// <summary>
        /// Operation: Delete Card
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/glip/cards/{cardId}
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Delete(CancellationToken? cancellationToken = null)
        {
            if (this.cardId == null)
            {
                throw new System.ArgumentNullException("cardId");
            }

            return await rc.Delete<string>(this.Path(), null, cancellationToken);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip
{
    public partial class Index
    {
        public Restapi.Glip.Cards.Index Cards(string cardId = null)
        {
            return new Restapi.Glip.Cards.Index(this, cardId);
        }
    }
}