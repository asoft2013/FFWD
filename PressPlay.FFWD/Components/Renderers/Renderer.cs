using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PressPlay.FFWD.Components
{
    public abstract class Renderer : Component
    {

        public Material material;
        public List<Material> materials;

        public override void Awake()
        {
            base.Awake();
        }

        public override void Start()
        {
            base.Start();
        }
    }
}
