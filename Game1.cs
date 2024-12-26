using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Minesweeper;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public MouseState _mouseState;
    public MouseState _previousMouseState;

    private Texture2D _checkedTexture;
    private Texture2D _flaggedTexture;
    private Texture2D _uncheckedTexture;
    private Texture2D _oneTexture;
    private Texture2D _twoTexture;
    private Texture2D _mineTexture;


    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        _graphics.IsFullScreen = false;

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
        _checkedTexture = Content.Load<Texture2D>("checked");
        _flaggedTexture = Content.Load<Texture2D>("flagged");
        _uncheckedTexture = Content.Load<Texture2D>("unchecked");
        _oneTexture = Content.Load<Texture2D>("one");
        _twoTexture = Content.Load<Texture2D>("two");
        _mineTexture = Content.Load<Texture2D>("mine");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}