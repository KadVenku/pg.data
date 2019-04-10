using pg.data.data.parameters.impl;

namespace pg.data.data.game.objects.impl
{
    public sealed class SensorJammingAbility : AbstractGameObjectType
    {
        public StringParameter DurationInSecs { get; } = new StringParameter("duration_in_secs");
        public StringParameter BlobColor { get; } = new StringParameter("blob_color");
        public StringParameter BlobMaterialName { get; } = new StringParameter("blob_material_name");
        
        public SensorJammingAbility(string id) : base(id)
        {
        }
    }
}