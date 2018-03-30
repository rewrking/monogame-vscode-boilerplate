using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGame
{
	class Sprite : Transformable
	{

		private Texture2D texture;
		private Rectangle textureRect;
		private Rectangle destRect;
		private Color color;
		/*
			Vertex m_vertices[4];
			const Texture* m_texture;
			IntRect m_textureRect;
		*/

		public Sprite()
		{
			this.color = Color.White;
		}

		public void SetTexture(ref Texture2D texture, bool resetRect = false)
		{
			this.texture = texture;
			if (resetRect) {
				Rectangle newRect = new Rectangle(0, 0, this.texture.Width, this.texture.Height);
				SetTextureRect(ref newRect);
			}
		}
		public void SetTextureRect(ref Rectangle rectangle)
		{
			if (rectangle != this.textureRect)
			{
				this.textureRect = rectangle;
				Resize();
				//UpdatePositions();
				//UpdateTexCoords();
			}
		}

		public override void Resize()
		{
			this.destRect = new Rectangle(
				this.position.X,
				this.position.Y,
				this.position.X + (int)(this.texture.Width * this.scale.X),
				this.position.Y + (int)(this.texture.Height * this.scale.Y)
			);
		}

		public void SetColor(Color color)
		{
			//this.texture.Bounds.Top
			if (this.color != color)
				this.color = color;
		}

		//===============================================
		public void Initialize()
		{
		}

		public void LoadContent(ContentManager content, string textureName)
		{
			Texture2D newTexture = content.Load<Texture2D>(textureName);
			SetTexture(ref newTexture, true);
		}

		public void Update(ref GameTime gameTime)
		{
		}

		public void Draw(ref SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(this.texture, this.destRect, this.textureRect, this.color, this.rotation, this.origin, SpriteEffects.None, 0);
		}
	}
}