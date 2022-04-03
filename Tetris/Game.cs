// Mahir Suljic - beannshie

using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Tetris
{
    #region Flags
    [Flags]
    public enum KeyPress
    {
        None = 0b_00000,
        Up = 0b_00001,
        Down = 0b_00010,
        Left = 0b_00100,
        Right = 0b_01000,
        Shift = 0b_10000
    }

    public enum Rotation
    {
        Up = 0b_0001,
        Right = 0b_0010,
        Down = 0b_0100,
        Left = 0b_1000
    }

    public enum ShapeType
    {
        L = 0b_0000001,
        J = 0b_0000010,
        O = 0b_0000100,
        S = 0b_0001000,
        Z = 0b_0010000,
        T = 0b_0100000,
        I = 0b_1000000
    }
    #endregion

    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        #region Classes
        class ShapeBody
        {
            #region L
            public static List<List<bool>> shape_L_U = new List<List<bool>> {
                new List<bool> { true, false },
                new List<bool> { true, false },
                new List<bool> { true, true  }
            };

            public static List<List<bool>> shape_L_R = new List<List<bool>> {
                new List<bool> { true, true , true  },
                new List<bool> { true, false, false }
            };

            public static List<List<bool>> shape_L_D = new List<List<bool>> {
                new List<bool> { true , true },
                new List<bool> { false, true },
                new List<bool> { false, true  }
            };

            public static List<List<bool>> shape_L_L = new List<List<bool>> {
                new List<bool> { false, false, true },
                new List<bool> { true , true , true }
            };

            public static List<List<bool>> GetL(Rotation rotation)
            {
                switch (rotation)
                {
                    case Rotation.Up:
                        return shape_L_U;
                    case Rotation.Right:
                        return shape_L_R;
                    case Rotation.Down:
                        return shape_L_D;
                    case Rotation.Left:
                        return shape_L_L;

                    default:
                        return shape_L_U;
                }
            }
            #endregion

            #region J
            public static List<List<bool>> shape_J_U = new List<List<bool>> {
                new List<bool> { false, true },
                new List<bool> { false, true },
                new List<bool> { true , true }
            };

            public static List<List<bool>> shape_J_R = new List<List<bool>> {
                new List<bool> { true, false, false },
                new List<bool> { true, true , true  }
            };

            public static List<List<bool>> shape_J_D = new List<List<bool>> {
                new List<bool> { true, true  },
                new List<bool> { true, false },
                new List<bool> { true, false }
            };

            public static List<List<bool>> shape_J_L = new List<List<bool>> {
                new List<bool> { true , true , true },
                new List<bool> { false, false, true }
            };

            public static List<List<bool>> GetJ(Rotation rotation)
            {
                switch (rotation)
                {
                    case Rotation.Up:
                        return shape_J_U;
                    case Rotation.Right:
                        return shape_J_R;
                    case Rotation.Down:
                        return shape_J_D;
                    case Rotation.Left:
                        return shape_J_L;

                    default:
                        return shape_J_U;
                }
            }
            #endregion

            #region O
            public static List<List<bool>> shape_O = new List<List<bool>> {
                new List<bool> { true, true },
                new List<bool> { true, true }
            };

            public static List<List<bool>> GetO(Rotation rotation)
            {
                return shape_O;
            }
            #endregion

            #region S
            public static List<List<bool>> shape_S_U = new List<List<bool>> {
                new List<bool> { false, true, true  },
                new List<bool> { true , true, false }
            };

            public static List<List<bool>> shape_S_R = new List<List<bool>> {
                new List<bool> { true , false },
                new List<bool> { true , true  },
                new List<bool> { false, true  }
            };

            public static List<List<bool>> GetS(Rotation rotation)
            {
                switch (rotation)
                {
                    case Rotation.Up:
                        return shape_S_U;
                    case Rotation.Right:
                        return shape_S_R;
                    case Rotation.Down:
                        return shape_S_U;
                    case Rotation.Left:
                        return shape_S_R;

                    default:
                        return shape_S_U;
                }
            }
            #endregion

            #region Z
            public static List<List<bool>> shape_Z_U = new List<List<bool>> {
                new List<bool> { true , true, false },
                new List<bool> { false, true, true  }
            };

            public static List<List<bool>> shape_Z_R = new List<List<bool>> {
                new List<bool> { false, true  },
                new List<bool> { true , true  },
                new List<bool> { true , false }
            };

            public static List<List<bool>> GetZ(Rotation rotation)
            {
                switch (rotation)
                {
                    case Rotation.Up:
                        return shape_Z_U;
                    case Rotation.Right:
                        return shape_Z_R;
                    case Rotation.Down:
                        return shape_Z_U;
                    case Rotation.Left:
                        return shape_Z_R;

                    default:
                        return shape_Z_U;
                }
            }
            #endregion

            #region T
            public static List<List<bool>> shape_T_U = new List<List<bool>> {
                new List<bool> { false, true, false },
                new List<bool> { true,  true, true  }
            };

            public static List<List<bool>> shape_T_R = new List<List<bool>> {
                new List<bool> { true, false },
                new List<bool> { true, true  },
                new List<bool> { true, false }
            };

            public static List<List<bool>> shape_T_D = new List<List<bool>> {
                new List<bool> { true , true, true  },
                new List<bool> { false, true, false }
            };

            public static List<List<bool>> shape_T_L = new List<List<bool>> {
                new List<bool> { false, true },
                new List<bool> { true , true },
                new List<bool> { false, true }
            };

            public static List<List<bool>> GetT(Rotation rotation)
            {
                switch (rotation)
                {
                    case Rotation.Up:
                        return shape_T_U;
                    case Rotation.Right:
                        return shape_T_R;
                    case Rotation.Down:
                        return shape_T_D;
                    case Rotation.Left:
                        return shape_T_L;

                    default:
                        return shape_T_U;
                }
            }
            #endregion

            #region I
            public static List<List<bool>> shape_I_U = new List<List<bool>> {
                new List<bool> { true },
                new List<bool> { true },
                new List<bool> { true },
                new List<bool> { true }
            };

            public static List<List<bool>> shape_I_R = new List<List<bool>> {
                new List<bool> { true, true, true, true }
            };

            public static List<List<bool>> GetI(Rotation rotation)
            {
                switch (rotation)
                {
                    case Rotation.Up:
                        return shape_I_U;
                    case Rotation.Right:
                        return shape_I_R;
                    case Rotation.Down:
                        return shape_I_U;
                    case Rotation.Left:
                        return shape_I_R;

                    default:
                        return shape_I_U;
                }
            }
            #endregion

            public static List<List<bool>> SetRotation(Shape shape)
            {
                try
                {
                    switch (shape.type)
                    {
                        case ShapeType.L:
                            return GetL(shape.rotation);
                        case ShapeType.J:
                            return GetJ(shape.rotation);
                        case ShapeType.O:
                            return GetO(shape.rotation);
                        case ShapeType.S:
                            return GetS(shape.rotation);
                        case ShapeType.Z:
                            return GetZ(shape.rotation);
                        case ShapeType.T:
                            return GetT(shape.rotation);
                        case ShapeType.I:
                            return GetI(shape.rotation);

                        default:
                            return GetO(shape.rotation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<List<bool>>();
                }
            }

            public static List<List<bool>> Random()
            {
                try
                {
                    switch (shapeRNG.Next(0, 7))
                    {
                        case 0:
                            return shape_I_U;
                        case 1:
                            return shape_J_U;
                        case 2:
                            return shape_L_U;
                        case 3:
                            return shape_O;
                        case 4:
                            return shape_S_U;
                        case 5:
                            return shape_T_U;
                        case 6:
                            return shape_Z_U;

                        default:
                            return shape_O;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<List<bool>>();
                }
            }

            public static Color GetColor(List<List<bool>> shape)
            {
                try
                {
                    if (shape == shape_I_U)
                        return Color.Blue;
                    if (shape == shape_J_U)
                        return Color.Green;
                    if (shape == shape_L_U)
                        return Color.DarkOrange;
                    if (shape == shape_O)
                        return Color.Red;
                    if (shape == shape_S_U)
                        return Color.Gold;
                    if (shape == shape_T_U)
                        return Color.SteelBlue;
                    if (shape == shape_Z_U)
                        return Color.DarkViolet;

                    return Color.Black;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return Color.Black;
                }
            }

            public static ShapeType GetType(List<List<bool>> shape)
            {
                try
                {
                    if (shape == shape_I_U)
                        return ShapeType.I;
                    if (shape == shape_J_U)
                        return ShapeType.J;
                    if (shape == shape_L_U)
                        return ShapeType.L;
                    if (shape == shape_O)
                        return ShapeType.O;
                    if (shape == shape_S_U)
                        return ShapeType.S;
                    if (shape == shape_T_U)
                        return ShapeType.T;
                    if (shape == shape_Z_U)
                        return ShapeType.Z;

                    return ShapeType.O;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return ShapeType.O;
                }
            }
        }

        class Shape
        {
            // variables
            public int x = 0;
            public int y = 0;
            public int w = 0;
            public int h = 0;

            public Color color;
            public ShapeType type;
            public Rotation rotation;
            public List<List<bool>> shape;

            // methods
            public void MapToGameArea(ref Pixel[,] pixels)
            {
                try
                {
                    for (int i = y; i < y + h; i++)
                        for (int j = x; j < x + w; j++)
                            if (shape[i - y][j - x])
                                pixels[i, j] = new Pixel(this.color, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // constructors
            public Shape(List<List<bool>> shape, int x = 0, int y = 0)
            {
                try
                {
                    this.color = ShapeBody.GetColor(shape);
                    this.type = ShapeBody.GetType(shape);
                    this.rotation = Rotation.Up;
                    this.shape = shape;

                    this.x = x;
                    this.y = y;
                    this.h = shape.Count;
                    this.w = shape[0].Count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public Shape(List<List<bool>> shape, ShapeType shapeType, Rotation rotation, int x = 0, int y = 0)
            {
                try
                {
                    this.color = ShapeBody.GetColor(shape);
                    this.type = shapeType;
                    this.rotation = rotation;
                    this.shape = shape;

                    this.x = x;
                    this.y = y;
                    this.h = shape.Count;
                    this.w = shape[0].Count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        class Pixel
        {
            public static int width = 30;
            public static int height = width;

            public bool visible = false;
            public Color color = Color.Transparent;

            public Pixel(Color color, bool visible = true)
            {
                try
                {
                    this.color = color;
                    this.visible = visible;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        class SoundEffects
        {
            private static Stream[,] sounds =
            {
                { Properties.Resources.PieceLand    , null                              , null                               },   // PieceLand
                { Properties.Resources.LineClear__1_, Properties.Resources.LineClear3   , Properties.Resources.LineClear4    },   // LineClear
                { Properties.Resources.HighScore__1_, Properties.Resources.HighScore__2_, Properties.Resources.HighScore__3_ },   // HighScore
                { Properties.Resources.GameOver__1_ , Properties.Resources.GameOver__2_ , null                               }    // GameOver
            };

            private static int NofSounds(string index)
            {
                try
                {
                    switch (index)
                    {
                        case "PiecePlace":
                            return 1;
                        case "LineClear":
                            return 2;
                        case "HighScore":
                            return 3;
                        case "GameOver":
                            return 2;

                        default:
                            return 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }

            private static string[] indexers = { "PieceLand", "LineClear", "HighScore", "GameOver" };

            public static Stream GetSound(string index, int n)
            {
                return sounds[Array.IndexOf(indexers, index), n];
            }

            public static Stream GetRandomSound(string index)
            {
                Random rnd = new Random();

                return sounds[Array.IndexOf(indexers, index), rnd.Next(0, NofSounds(index))];
            }
        }

        #endregion

        #region Other
        private static Color GetDarkerColor(Color c)
        {
            try
            {
                int R, G, B;

                if (c == Color.Red || c == Color.Magenta)
                    R = c.R - darkConst * 3;
                else if (c.R > darkConst)
                    R = c.R - darkConst;
                else
                    R = c.R;

                if (c.G > darkConst)
                    G = c.G - darkConst;
                else
                    G = c.G;

                if (c == Color.Blue)
                    B = c.B - darkConst * 3;
                else if (c.B > darkConst)
                    B = c.B - darkConst;
                else
                    B = c.B;

                return Color.FromArgb(R, G, B);
            }
            catch (Exception ex)
            {
                throw ex; //MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitGameArea()
        {
            try
            {
                gameArea = new Pixel[gameH, gameW];

                for (int i = 0; i < gameH; i++)
                    for (int j = 0; j < gameW; j++)
                        gameArea[i, j] = new Pixel(Color.Transparent, false);
            }
            catch (Exception ex)
            {
                throw ex; //MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Updates
        private void UpdateGameStats()
        {
            gameStats.Text = "Score\n" + score + "\nLevel\n" + level + "\nLines\n" + lines;
        }

        private void ResetGameStats()
        {
            try
            {
                score = 0;
                lines = 0;

                gameStats.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                throw ex; //MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateScoreboard()
        {
            try
            {
                scoreboardScores = new List<int>();

                foreach (string s in Properties.Settings.Default.scoreboard.Split(';'))
                    scoreboardScores.Add(Convert.ToInt32(s.Split('-')[1].Substring(1)));

                if (scoreboardScores.Count > 0)
                    Properties.Settings.Default.highScore = scoreboardScores[0];
                else
                    Properties.Settings.Default.highScore = 0;

                Properties.Settings.Default.Save();

                if (!String.IsNullOrEmpty(Properties.Settings.Default.scoreboard))
                {
                    string scores = String.Empty;
                    int i = 1;

                    foreach (string s in Properties.Settings.Default.scoreboard.Split(';'))
                        scores += i++.ToString() + ". " + s + "\n";

                    lb_scoreboard.Text = "Scoreboard\n\n" + scores;
                }
                else
                    lb_scoreboard.Text = "Scoreboard\n\n";

                panel_highscore.Location = new Point(this.Width / 2 - panel_highscore.Width / 2, this.Height / 2 - panel_highscore.Height / 2);
            }
            catch (Exception ex)
            {
                throw ex; //MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCurrentSongDisplay()
        {
            lb_currentSong.Text = "Now playing\n" + GetSongName(songIndex);
            lb_currentSong.Location = new Point(this.Width / 2 - lb_currentSong.Width / 2, gameY + gameH * Pixel.height + 20);
        }

        public static byte[] ReadToEnd(Stream stream)
        {
            long originalPosition = 0;

            if (stream.CanSeek)
            {
                originalPosition = stream.Position;
                stream.Position = 0;
            }

            try
            {
                byte[] readBuffer = new byte[4096];

                int totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead == readBuffer.Length)
                    {
                        int nextByte = stream.ReadByte();
                        if (nextByte != -1)
                        {
                            byte[] temp = new byte[readBuffer.Length * 2];
                            Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                            Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                            readBuffer = temp;
                            totalBytesRead++;
                        }
                    }
                }

                byte[] buffer = readBuffer;
                if (readBuffer.Length != totalBytesRead)
                {
                    buffer = new byte[totalBytesRead];
                    Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                }
                return buffer;
            }
            finally
            {
                if (stream.CanSeek)
                {
                    stream.Position = originalPosition;
                }
            }
        }

        #endregion

        #region Game Control Methods
        private void EndGame()
        {
            try
            {
                if (!panel_levelChoose.Visible)
                {
                    if (WaveOut.DeviceCount > 0)
                        musicPlayer.Stop();

                    currentKeys = Tetris.KeyPress.None;

                    bool top10 = false;
                    int n = 0;

                    foreach (int s in scoreboardScores)
                    {
                        if (score >= s)
                        {
                            top10 = true;
                            n = scoreboardScores.IndexOf(s) + 1;
                            break;
                        }
                    }

                    if (top10)
                    {
                        lb_highScore.Text = "High score\n" + Properties.Settings.Default.highScore;

                        PlaySound("HighScore");

                        string alertText = String.Empty;

                        switch (n)
                        {
                            case 1:
                                alertText = "Congratulations!\n\nYOU GOT THE HIGHEST SCORE!\n\nYour score was : " + score.ToString();
                                break;
                            case 2:
                                alertText = "Congratulations!\n\nYOU GOT THE 2nd HIGHEST SCORE!\n\nYour score was : " + score.ToString();
                                break;
                            case 3:
                                alertText = "Congratulations!\n\nYOU GOT THE 3rd HIGHEST SCORE!\n\nYour score was : " + score.ToString();
                                break;
                            default:
                                alertText = "Congratulations!\n\nYou got the " + n + "th highest score!\n\nYour score was : " + score.ToString();
                                break;
                        }

                        if (n == 1)
                        {
                            Properties.Settings.Default.highScore = score;
                            Properties.Settings.Default.Save();
                        }

                        MessageBox.Show(alertText, "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        panel_highscore.Enabled = true;
                        panel_highscore.Visible = true;
                    }
                    else
                    {
                        PlaySound("GameOver");
                        MessageBox.Show("Congratulations!\nYour score was : " + score.ToString(), "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    musicPlayer.Stop();
                    inputClock.Enabled = false;
                    gameClock.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartGame()
        {
            try
            {
                ResetGameStats();
                UpdateGameStats();
                UpdateScoreboard();

                InitGameArea();

                nextShapes = new List<Shape>();

                for (int i = 0; i < nextShapeCount; i++)
                    nextShapes.Add(new Shape(ShapeBody.Random(), gameW + 2, 1));

                currentShape = new Shape(ShapeBody.Random(), gameW / 2 - 1, 0);

                inputClock.Interval = inputLatency - level / 2;
                gameClock.Interval = levelSpeed[level - 1];
                this.Focus();

                display.Refresh();

                PlaySong();

                inputClock.Enabled = true;
                gameClock.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Audio

        private Stream GetSong(int n = -1)
        {
            try
            {
                if (n == -1)
                {
                    Random rnd = new Random();
                    n = rnd.Next(0, 9);
                }

                switch (n)
                {
                    case 0:
                        songIndex = 0;
                        UpdateCurrentSongDisplay();
                        return Properties.Resources.Original_Tetris_theme__Tetris_Soundtrack_;
                    case 1:
                        songIndex = 1;
                        UpdateCurrentSongDisplay();
                        return Properties.Resources.Tetris_99___Main_Theme;
                    case 2:
                        songIndex = 2;
                        UpdateCurrentSongDisplay();
                        return Properties.Resources.TETRIS___Theme_A___Metal_Cover_by_RichaadEB;
                    case 3:
                        songIndex = 3;
                        UpdateCurrentSongDisplay();
                        return Properties.Resources.Cement_City___Death_Mode_Tetris__BASS_BOOSTED_;
                    case 4:
                        songIndex = 4;
                        UpdateCurrentSongDisplay();
                        return Properties.Resources.Tetris_Theme__Dubstep_Remix_;
                    case 5:
                        songIndex = 5;
                        UpdateCurrentSongDisplay();
                        return Properties.Resources.Tetris_Theme__Techno_Remix_;
                    case 6:
                        songIndex = 6;
                        UpdateCurrentSongDisplay();
                        return Properties.Resources.Techno___Tetris__Remix_;
                    case 7:
                        songIndex = 7;
                        UpdateCurrentSongDisplay();
                        return Properties.Resources.Octopodes___Korobeiniki__Tetris_Remix_;
                    case 8:
                        songIndex = 8;
                        UpdateCurrentSongDisplay();
                        return Properties.Resources.Tetris_Theme_Song__Trap_Remix___Bass_Boosted_;

                    default:
                        songIndex = 0;
                        UpdateCurrentSongDisplay();
                        return Properties.Resources.Original_Tetris_theme__Tetris_Soundtrack_;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Properties.Resources.Original_Tetris_theme__Tetris_Soundtrack_;
            }
        }

        private void PlaySong(int n = -1)
        {
            try
            {
                if (WaveOut.DeviceCount > 0)
                {
                    byte[] b = ReadToEnd(GetSong(n));

                    musicPlayer.Dispose();

                    WaveStream wav = new RawSourceWaveStream(new MemoryStream(b), new WaveFormat(44100, 16, 2));
                    musicPlayer.Init(wav);
                    musicPlayer.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlaySound(string type, int version = -1)
        {
            try
            {
                if (WaveOut.DeviceCount > 0)
                {
                    Stream sound;

                    if (version != -1)
                        sound = SoundEffects.GetSound(type, version);
                    else
                        sound = SoundEffects.GetRandomSound(type);

                    byte[] b = ReadToEnd(sound);

                    WaveStream wav = new RawSourceWaveStream(new MemoryStream(b), new WaveFormat(44100, 16, 2));
                    soundPlayer = new WaveOutEvent();
                    soundPlayer.Init(wav);
                    soundPlayer.Play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSongName(int n)
        {
            try
            {
                switch (n)
                {
                    case 0:
                        return "Original Tetris theme (Tetris Soundtrack)";
                    case 1:
                        return "Tetris 99 - Main Theme";
                    case 2:
                        return "TETRIS - Theme A _ Metal Cover by RichaadEB";
                    case 3:
                        return "Cement City - Death Mode Tetris !BASS BOOSTED!";
                    case 4:
                        return "Tetris Theme (Dubstep Remix)";
                    case 5:
                        return "Tetris Theme (Techno Remix)";
                    case 6:
                        return "Techno - Tetris (Remix)";
                    case 7:
                        return "Octopodes - Korobeiniki (Tetris Remix)";
                    case 8:
                        return "Tetris Theme Song (Trap Remix) [Bass Boosted]";

                    default:
                        return "Original Tetris theme (Tetris Soundtrack)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error!";
            }
        }

        #endregion

        #region Pause
        private void TogglePause()
        {
            try
            {
                if (!panel_levelChoose.Visible && !panel_highscore.Visible)
                {
                    gameClock.Enabled = !gameClock.Enabled;
                    inputClock.Enabled = !inputClock.Enabled;


                    if (WaveOut.DeviceCount > 0)
                    {
                        if (gameClock.Enabled)
                            musicPlayer.Play();
                        else
                            musicPlayer.Pause();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetPause(bool pause)
        {
            try
            {
                if (!panel_levelChoose.Visible && !panel_highscore.Visible)
                {
                    gameClock.Enabled = pause;
                    inputClock.Enabled = pause;

                    if (WaveOut.DeviceCount > 0)
                    {
                        if (gameClock.Enabled)
                            musicPlayer.Play();
                        else
                            musicPlayer.Pause();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void Game_Load(object sender, EventArgs e)
        {
            try
            {
                gameX = this.Width / 2 - (gameW * Pixel.width) / 2;

                InitGameArea();

                float w = 4f;
                float h = 5.5f;

                lb_highScore.Text = "High score\n" + Properties.Settings.Default.highScore;

                gameStats.Size = new Size((int)(w * Pixel.width), (int)(h * Pixel.height + 10));
                gameStats.Location = new Point(gameX / 2 - gameStats.Width / 2, this.Height / 2 - gameStats.Height / 3);
                lb_controls.Location = new Point(this.Width / 2 - lb_controls.Width / 2, this.Height / 2 - lb_controls.Height / 2);
                lb_highScore.Location = new Point(gameStats.Location.X + gameStats.Width / 2 - lb_highScore.Width / 2, gameStats.Location.Y + gameStats.Height + 20);
                lb_scoreboard.Location = new Point(this.Width / 2 - lb_scoreboard.Width / 2, this.Height / 2 - lb_scoreboard.Height / 2);
                lb_currentSong.Location = new Point(this.Width / 2 - lb_currentSong.Width / 2, gameY + gameH * Pixel.height + 20);
                panel_levelChoose.Location = new Point(this.Width / 2 - panel_levelChoose.Width / 2, this.Height / 2 - panel_levelChoose.Height);

                this.BackColor = backgroundColor;
                gameStats.BackColor = gameWindowsColor;
                lb_controls.BackColor = gameWindowsColor;
                lb_highScore.BackColor = gameWindowsColor;
                lb_scoreboard.BackColor = gameWindowsColor;
                lb_currentSong.BackColor = gameWindowsColor;
                panel_highscore.BackColor = gameWindowsColor;
                panel_levelChoose.BackColor = gameWindowsColor;

                Properties.Settings.Default.scoreboard = "beannshie - 10000;test - 5000;test2 - 2500;test3 - 500;test4 - 100";
                Properties.Settings.Default.Save();

                UpdateScoreboard();
                lb_controls.SendToBack();

                label5.BackColor = Color.LightBlue;

                panel_highscore.Visible = false;
                panel_highscore.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Main Variables

        // esthetic
        static Color backgroundColor = Color.FromArgb(50, 50, 50);
        static Color gameWindowsColor = Color.Cyan;
        static int darkConst = 30;

        // timing
        static int inputLatency = 50;
        static int downSpeedUpConst = 10;
        static int maxLevelSpeed = 30;
        static int[] levelSpeed = { 799, 716, 632, 549, 466, 383, 300, 216, 133, 100, 83, 83, 83, 67, 67, 67, 50, 50, 50, 33, 33, 33, 33, 33, 33, 33, 33, 33, 33, 17 };

        bool rotationEnabled = true;

        // gameArea
        static int gameW = 10;
        static int gameH = 20;
        static int gameX = 200;
        static int gameY = 50;

        // stats
        int score = 0;
        int level = 1;
        int lines = 0;
        int startingLevel = 1;

        static int shapePlacedScoreValue = 10;
        static int[] rowScore = { 40, 100, 300, 1200 };

        List<int> scoreboardScores = new List<int>();

        // game
        KeyPress currentKeys = Tetris.KeyPress.None;

        Shape heldShape = null;
        Shape currentShape = new Shape(ShapeBody.Random(), gameW / 2 - 1, 0);
        List<Shape> nextShapes = new List<Shape>();

        Pixel[,] gameArea = new Pixel[gameH, gameW];

        WaveOutEvent musicPlayer = new WaveOutEvent();
        WaveOutEvent soundPlayer = new WaveOutEvent();

        static Random shapeRNG = new Random();

        const int nextShapeCount = 3;
        static int songIndex = 0;

        static bool shiftMovedLeft = false;
        static bool shiftMovedRight = false;
        static bool shapeHeldThisTurn = false;

        #endregion

        #region Drawing

        #region GameArea
        private void DrawGameArea(PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.Black, Pixel.width / 6))
            {
                e.Graphics.DrawRectangle(p, gameX - p.Width, gameY - p.Width, gameW * Pixel.width + p.Width * 2, gameH * Pixel.height + p.Width * 2);

                p.Width = Pixel.width / 15;

                int x = gameX;
                int y = gameY;

                for (int i = 0; i < gameH; i++)
                {
                    x = gameX;

                    for (int j = 0; j < gameW; j++)
                    {
                        e.Graphics.DrawRectangle(p, x, y, Pixel.width, Pixel.height);

                        x += Pixel.width;
                    }

                    y += Pixel.height;
                }
            }

            DrawGameAreaPixels(e);
        }

        private void DrawGameAreaPixels(PaintEventArgs e)
        {
            for (int i = 0; i < gameH; i++)
            {
                for (int j = 0; j < gameW; j++)
                {
                    Pixel currentPixel = gameArea[i, j];

                    if (currentPixel.visible)
                    {
                        using (SolidBrush sb = new SolidBrush(currentPixel.color))
                        {
                            int x = gameX + j * Pixel.width;
                            int y = gameY + i * Pixel.height;

                            using (Pen p = new Pen(GetDarkerColor(sb.Color), Pixel.width / 6))
                            {
                                e.Graphics.FillRectangle(sb, x, y, Pixel.width, Pixel.height);
                                e.Graphics.DrawRectangle(p, x + p.Width / 2, y + p.Width / 2, Pixel.width - p.Width, Pixel.height - p.Width);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Containers
        private void DrawContainers(PaintEventArgs e)
        {
            DrawContainer_HeldShape(e);
            DrawContainer_NextShape(e);
        }

        private void DrawContainer_HeldShape(PaintEventArgs e)
        {
            using (SolidBrush sb = new SolidBrush(gameWindowsColor))
            {
                float w = 4;
                float h = 6;
                float x = gameX / 2 - (w * Pixel.width) / 2;
                float y = gameY;

                e.Graphics.FillRectangle(sb, x, y, Pixel.width * w, Pixel.height * h);

                using (Pen p = new Pen(GetDarkerColor(sb.Color), Pixel.width / 15))
                {
                    e.Graphics.DrawRectangle(p, x + p.Width / 2, y + p.Width / 2, Pixel.width * w, Pixel.height * h);
                }

                e.Graphics.DrawString("Hold", new Font(FontFamily.GenericSansSerif, 16), new SolidBrush(Color.Black), x + w * Pixel.width / 2 - e.Graphics.MeasureString("Hold", new Font(FontFamily.GenericSansSerif, 16)).Width / 2, gameY + 5);
            }
        }

        private void DrawContainer_NextShape(PaintEventArgs e)
        {
            using (SolidBrush sb = new SolidBrush(gameWindowsColor))
            {
                float x = gameX + gameW * Pixel.width + Pixel.width * 1.5f;
                float y = gameY;
                float w = 4;
                float h = 4 * nextShapeCount + nextShapeCount + 1;

                e.Graphics.FillRectangle(sb, x, y, Pixel.width * w, Pixel.height * h);

                using (Pen p = new Pen(GetDarkerColor(sb.Color), Pixel.width / 15))
                {
                    e.Graphics.DrawRectangle(p, x + p.Width / 2, y + p.Width / 2, Pixel.width * w, Pixel.height * h);
                }
            }

            // sections
            using (Pen p = new Pen(GetDarkerColor(gameWindowsColor), Pixel.width / 15))
            {
                float x = gameX + gameW * Pixel.width + Pixel.width * 1.5f;
                float w = 4;
                float h = 5;

                float yh = gameY + (4 * nextShapeCount + nextShapeCount + 1) * Pixel.height;

                for (int i = nextShapeCount; i > 0; i--)
                {
                    float y = yh - Pixel.height * h * i;

                    e.Graphics.DrawRectangle(p, x + p.Width / 2, y + p.Width / 2, Pixel.width * w, Pixel.height * h);
                }
            }
        }
        #endregion

        #region Shapes
        private void DrawShapes(PaintEventArgs e)
        {
            if (currentShape != null && nextShapes.Count > 0)
            {
                DrawShapes_CurrentShape(e);
                DrawShapes_HeldShape(e);
                DrawShapes_NextShapes(e);
            }
        }

        private void DrawShapes_CurrentShape(PaintEventArgs e)
        {
            using (SolidBrush sb = new SolidBrush(currentShape.color))
            {
                int x = gameX + currentShape.x * Pixel.width;
                int y = gameY + currentShape.y * Pixel.height;

                using (Pen p = new Pen(GetDarkerColor(sb.Color), Pixel.width / 6))
                {
                    foreach (List<bool> bL in currentShape.shape)
                    {
                        x = gameX + currentShape.x * Pixel.width;

                        foreach (bool b in bL)
                        {
                            if (b)
                            {
                                e.Graphics.FillRectangle(sb, x, y, Pixel.width, Pixel.height);
                                e.Graphics.DrawRectangle(p, x + p.Width / 2, y + p.Width / 2, Pixel.width - p.Width, Pixel.height - p.Width);
                            }

                            x += Pixel.width;
                        }

                        y += Pixel.height;
                    }
                }
            }
        }

        private void DrawShapes_HeldShape(PaintEventArgs e)
        {
            if (heldShape != null)
            {
                using (SolidBrush sb = new SolidBrush(heldShape.color))
                {
                    float x = gameX / 2 - heldShape.w * Pixel.width / 2;
                    float y = gameY + 10 + (3 * Pixel.height) - heldShape.h * Pixel.height / 2;

                    using (Pen p = new Pen(GetDarkerColor(sb.Color), Pixel.width / 6))
                    {
                        foreach (List<bool> bL in heldShape.shape)
                        {
                            x = gameX / 2 - heldShape.w * Pixel.width / 2;

                            foreach (bool b in bL)
                            {
                                if (b)
                                {
                                    e.Graphics.FillRectangle(sb, x, y, Pixel.width, Pixel.height);
                                    e.Graphics.DrawRectangle(p, x + p.Width / 2, y + p.Width / 2, Pixel.width - p.Width, Pixel.height - p.Width);
                                }

                                x += Pixel.width;
                            }

                            y += Pixel.height;
                        }
                    }
                }
            }
        }

        private void DrawShapes_NextShapes(PaintEventArgs e)
        {
            for (int i = 0; i < nextShapeCount; i++)
            {
                using (SolidBrush sb = new SolidBrush(nextShapes[i].color))
                {
                    float baseX = gameX + nextShapes[i].x * Pixel.width + (3 - nextShapes[i].w) * (Pixel.width / 2) + 2.5f;
                    float x = baseX;
                    float h = 5;
                    //float yh = gameY + (4 * nextShapeCount + nextShapeCount + 1) * Pixel.height;
                    float yh = gameY + Pixel.height;

                    float y = yh + Pixel.height * h * i + h * Pixel.height / 2 - nextShapes[i].h * Pixel.height / 2;

                    using (Pen p = new Pen(GetDarkerColor(sb.Color), Pixel.width / 6))
                    {
                        foreach (List<bool> bL in nextShapes[i].shape)
                        {
                            x = baseX;

                            foreach (bool b in bL)
                            {
                                if (b)
                                {
                                    e.Graphics.FillRectangle(sb, x, y, Pixel.width, Pixel.height);
                                    e.Graphics.DrawRectangle(p, x + p.Width / 2, y + p.Width / 2, Pixel.width - p.Width, Pixel.height - p.Width);
                                }

                                x += Pixel.width;
                            }

                            y += Pixel.height;
                        }
                    }
                }
            }
        }
        #endregion

        #region Other
        private void DrawOther(PaintEventArgs e)
        {
            e.Graphics.DrawString("Next", new Font(FontFamily.GenericSansSerif, 16), new SolidBrush(Color.Black), (gameX + gameW * Pixel.width + Pixel.width * 1.5f) + 2 * Pixel.width - e.Graphics.MeasureString("Next", new Font(FontFamily.GenericSansSerif, 16)).Width / 2, gameY + 5);
        }
        #endregion

        private void display_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                DrawGameArea(e);
                DrawContainers(e);
                DrawShapes(e);
                DrawOther(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawBorder(object sender, PaintEventArgs e)
        {
            try
            {
                Color col = GetDarkerColor(gameWindowsColor);
                ButtonBorderStyle bbs = ButtonBorderStyle.Solid;
                int thickness = 2;
                ControlPaint.DrawBorder(e.Graphics, ((Label)sender).ClientRectangle, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region KeyHandles
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        currentKeys |= Tetris.KeyPress.Up;
                        break;
                    case Keys.Down:
                        currentKeys |= Tetris.KeyPress.Down;
                        break;
                    case Keys.Left:
                        currentKeys |= Tetris.KeyPress.Left;
                        break;
                    case Keys.Right:
                        currentKeys |= Tetris.KeyPress.Right;
                        break;
                    case Keys.ShiftKey:
                        currentKeys |= Tetris.KeyPress.Shift;
                        break;
                }

                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        currentKeys = currentKeys & ~Tetris.KeyPress.Up;
                        rotationEnabled = true;
                        break;
                    case Keys.Down:
                        currentKeys = currentKeys & ~Tetris.KeyPress.Down;
                        gameClock.Interval = levelSpeed[level - 1];
                        break;
                    case Keys.Left:
                        currentKeys = currentKeys & ~Tetris.KeyPress.Left;
                        shiftMovedRight = false;
                        shiftMovedLeft = false;
                        break;
                    case Keys.Right:
                        currentKeys = currentKeys & ~Tetris.KeyPress.Right;
                        shiftMovedRight = false;
                        shiftMovedLeft = false;
                        break;
                    case Keys.ShiftKey:
                        currentKeys = currentKeys & ~Tetris.KeyPress.Shift;
                        shiftMovedLeft = false;
                        shiftMovedRight = false;
                        break;

                    case Keys.Space:
                        gameClock.Interval = 1;
                        score += gameH - currentShape.y;
                        break;
                    case Keys.C:
                        if (heldShape == null && !shapeHeldThisTurn)
                        {
                            nextShapes[0].x = currentShape.x;
                            nextShapes[0].y = currentShape.y;

                            heldShape = currentShape;
                            currentShape = nextShapes[0];

                            for (int i = 0; i < nextShapeCount - 1; i++)
                                nextShapes[i] = nextShapes[i + 1];

                            nextShapes[nextShapeCount - 1] = new Shape(ShapeBody.Random(), gameW + 2, 1);

                            shapeHeldThisTurn = true;
                        }
                        else if (!shapeHeldThisTurn)
                        {
                            if (heldShape.w > currentShape.w)
                            {
                                if (currentShape.x + heldShape.w <= gameW)
                                {
                                    Shape temp = currentShape;
                                    currentShape = heldShape;

                                    currentShape.x = temp.x;
                                    currentShape.y = temp.y;

                                    heldShape = temp;

                                    shapeHeldThisTurn = true;
                                }
                            }
                            else
                            {
                                Shape temp = currentShape;
                                currentShape = heldShape;

                                currentShape.x = temp.x;
                                currentShape.y = temp.y;

                                heldShape = temp;

                                shapeHeldThisTurn = true;
                            }
                        }

                        display.Refresh();
                        break;
                    case Keys.P:
                        TogglePause();
                        break;
                    case Keys.R:
                        EndGame();
                        StartGame();
                        break;

                    #region MusicControls
                    case Keys.J:
                        songIndex--;

                        if (songIndex < 0)
                            songIndex = 8;

                        if (WaveOut.DeviceCount > 0)
                        {
                            musicPlayer.Stop();
                            PlaySong(songIndex);
                        }
                        break;
                    case Keys.L:
                        songIndex++;

                        if (songIndex > 8)
                            songIndex = 0;

                        if (WaveOut.DeviceCount > 0)
                        {
                            musicPlayer.Stop();
                            PlaySong(songIndex);
                        }
                        break;
                    case Keys.K:
                        if (WaveOut.DeviceCount > 0)
                        {
                            if (musicPlayer.PlaybackState == PlaybackState.Playing)
                                musicPlayer.Pause();
                            else
                                musicPlayer.Play();
                        }
                        break;
                    case Keys.H:
                        if (WaveOut.DeviceCount > 0)
                        {
                            musicPlayer.Stop();
                            PlaySong();
                        }
                        break;
                    case Keys.M:
                        if (WaveOut.DeviceCount > 0)
                        {
                            if (musicPlayer.Volume > 0)
                                musicPlayer.Volume = 0.0f;
                            else
                                musicPlayer.Volume = 1.0f;
                        }
                        break;
                        #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Debug
        //bool debugBool = false;

        private void displayGameArea()
        {
            string game = String.Empty;

            for (int i = 0; i < gameH; i++)
            {
                for (int j = 0; j < gameW; j++)
                {
                    if (gameArea[i, j].visible)
                        game += "#";
                    else
                        game += "O";
                }

                game += "\n";
            }

            label6.Text = game;
        }

        private void DisplayScoreboardScores()
        {
            string scores = String.Empty;

            foreach (int s in scoreboardScores)
                scores += s + "\n";

            MessageBox.Show(scores);
        }

        private string ShapeToString(List<List<bool>> shape)
        {
            string s = String.Empty;

            for (int i = 0; i < shape.Count; i++)
            {
                for (int j = 0; j < shape[0].Count; j++)
                {
                    if (shape[i][j])
                        s += "#";
                    else
                        s += "O";
                }

                s += "\n";
            }

            return s;
        }

        private string CKString()
        {
            string s = String.Empty;
            int n = 1;

            for (int i = 0; i < 5; i++)
            {
                if ((((int)currentKeys) & n) > 0)
                    s += 1;
                else
                    s += 0;

                n = n << 1;
            }

            return s;
        }

        private void ToggleClocks()
        {
            gameClock.Enabled = !gameClock.Enabled;
            inputClock.Enabled = !inputClock.Enabled;
        }

        #endregion

        #region Piece Methods

        private void PieceLanded()
        {
            try
            {
                PlaySound("PieceLand");

                bool gameOver = false;

                nextShapes[0].x = gameW / 2 - 1;
                nextShapes[0].y = 0;
                score += shapePlacedScoreValue * level;

                currentShape.MapToGameArea(ref gameArea);

                int multiplier = 0;

                for (int i = 0; i < gameH; i++)
                {
                    bool rowFull = true;

                    for (int j = 0; j < gameW; j++)
                    {
                        if (!gameArea[i, j].visible)
                        {
                            rowFull = false;
                            break;
                        }
                    }

                    if (rowFull)
                    {
                        multiplier++;
                        lines++;

                        for (int k = i - 1; k >= 0; k--)
                            for (int j = 0; j < gameW; j++)
                                gameArea[k + 1, j] = gameArea[k, j];
                    }
                }

                switch (multiplier)
                {
                    case 1:
                    case 2:
                        PlaySound("LineClear", 2);
                        break;
                    case 3:
                        PlaySound("LineClear", 1);
                        break;
                    case 4:
                        PlaySound("LineClear", 0);
                        break;
                }

                if (multiplier > 0)
                    score += rowScore[multiplier - 1] * level;

                if (score > Properties.Settings.Default.highScore)
                    gameStats.ForeColor = Color.Green;

                level = startingLevel + lines / 10;

                UpdateGameStats();

                for (int i = 0; i < gameW; i++)
                {
                    if (gameArea[0, i].visible)
                    {
                        gameOver = true;
                        break;
                    }
                }

                if (gameOver)
                {
                    EndGame();
                }
                else
                {
                    currentShape = nextShapes[0];

                    for (int i = 0; i < nextShapeCount - 1; i++)
                        nextShapes[i] = nextShapes[i + 1];

                    nextShapes[nextShapeCount - 1] = new Shape(ShapeBody.Random(), gameW + 2, 1);

                    shapeHeldThisTurn = false;
                }

                if (level < maxLevelSpeed)
                    gameClock.Interval = levelSpeed[level - 1];
                else
                    gameClock.Interval = levelSpeed[29];
            }
            catch (Exception ex)
            {
                throw ex;//MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RotateShape(Shape shape)
        {
            try
            {
                switch (shape.rotation)
                {
                    case Rotation.Up:
                        shape.rotation = Rotation.Right;
                        break;

                    case Rotation.Right:
                        shape.rotation = Rotation.Down;
                        break;

                    case Rotation.Down:
                        shape.rotation = Rotation.Left;
                        break;

                    case Rotation.Left:
                        shape.rotation = Rotation.Up;
                        break;
                }

                shape.shape = ShapeBody.SetRotation(shape);

                shape.h = shape.shape.Count;
                shape.w = shape.shape[0].Count;

                if (currentShape.x > gameW - currentShape.w)
                    currentShape.x = gameW - currentShape.w - 1;
            }
            catch (Exception ex)
            {
                throw ex;//MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool MoveLeft(bool forRotation = false)
        {
            try
            {
                if ((currentKeys & Tetris.KeyPress.Left) > 0 || forRotation)
                {
                    if (currentShape.x > 0 && !shiftMovedLeft)
                    {
                        // x axis collison checking - left

                        int brickCount = 0;

                        for (int j = 0; j < currentShape.w; j++)
                            for (int i = 0; i < currentShape.h; i++)
                                if (gameArea[currentShape.y + i, currentShape.x + j - 1].visible)
                                    brickCount++;

                        label6.Text = brickCount.ToString();

                        if (brickCount == 0)
                        {
                            currentShape.x--;
                            display.Refresh();

                            if ((currentKeys & Tetris.KeyPress.Shift) > 0)
                                shiftMovedLeft = true;

                            return true;
                        }
                        else
                        {
                            bool canPass = true;

                            for (int j = 0; j < currentShape.w; j++)
                            {
                                for (int i = 0; i < currentShape.h; i++)
                                {
                                    if (currentShape.shape[i][j] && gameArea[currentShape.y + i, currentShape.x + j - 1].visible)
                                        canPass = false;
                                }
                            }

                            if (canPass)
                            {
                                currentShape.x--;
                                display.Refresh();

                                if ((currentKeys & Tetris.KeyPress.Shift) > 0)
                                    shiftMovedLeft = true;

                                return true;
                            }
                        }

                        if ((currentKeys & Tetris.KeyPress.Shift) > 0)
                            shiftMovedLeft = true;
                    }

                    label3.BackColor = Color.LightGreen;
                }
                else
                    label3.BackColor = Color.Red;

                return false;
            }
            catch (Exception ex)
            {
                throw ex;//MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MoveRight()
        {
            try
            {
                if ((currentKeys & Tetris.KeyPress.Right) > 0)
                {
                    if (currentShape.x < gameW - currentShape.w && !shiftMovedRight)
                    {
                        // x axis collison checking - right

                        int brickCount = 0;

                        for (int j = 0; j < currentShape.w; j++)
                            for (int i = 0; i < currentShape.h; i++)
                                if (gameArea[currentShape.y + i, currentShape.x + currentShape.w - j].visible)
                                    brickCount++;

                        label6.Text = brickCount.ToString();

                        if (brickCount == 0)
                        {
                            currentShape.x++;
                            display.Refresh();
                        }
                        else
                        {
                            bool canPass = true;

                            for (int j = 0; j < currentShape.w; j++)
                            {
                                for (int i = 0; i < currentShape.h; i++)
                                {
                                    if (currentShape.shape[i][currentShape.w - j - 1] && gameArea[currentShape.y + i, currentShape.x + currentShape.w - j].visible)
                                        canPass = false;
                                }
                            }

                            if (canPass)
                            {
                                currentShape.x++;
                                display.Refresh();
                            }
                        }

                        if ((currentKeys & Tetris.KeyPress.Shift) > 0)
                            shiftMovedRight = true;
                    }

                    label4.BackColor = Color.LightGreen;
                }
                else
                    label4.BackColor = Color.Red;
            }
            catch (Exception ex)
            {
                throw ex;//MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Clocks
        private void inputClock_Tick(object sender, EventArgs e)
        {
            try
            {
                // UP
                if ((currentKeys & Tetris.KeyPress.Up) > 0)
                {
                    label1.BackColor = Color.LightGreen;

                    if (rotationEnabled)
                    {
                        Shape tempShape = new Shape(currentShape.shape, currentShape.type, currentShape.rotation, currentShape.x, currentShape.y);

                        RotateShape(tempShape);

                        label7.BackColor = Color.Red;
                        label8.BackColor = Color.Red;
                        label9.BackColor = Color.White;
                        label9.Text = "W : " + tempShape.w + "\nH : " + tempShape.h;

                        if (tempShape.w > currentShape.w)
                        {
                            label7.BackColor = Color.LightGreen;

                            if (tempShape.x + tempShape.w <= gameW)
                            {
                                bool canRotate = true;

                                for (int i = 0; i < tempShape.h; i++)
                                    if (tempShape.shape[i][tempShape.w - 1] && gameArea[tempShape.y + i, tempShape.x + tempShape.w - 1].visible)
                                        canRotate = false;

                                if (canRotate)
                                    RotateShape(currentShape);
                            }
                            else if (MoveLeft(true))
                                RotateShape(currentShape);
                        }
                        else
                        {
                            label7.BackColor = Color.Red;

                            if (tempShape.h > currentShape.h)
                            {
                                label8.BackColor = Color.LightGreen;

                                bool canRotate = true;

                                for (int i = 0; i < tempShape.w; i++)
                                    if (tempShape.shape[tempShape.h - 1][i] && gameArea[tempShape.y + tempShape.h - 1, tempShape.x + i].visible)
                                        canRotate = false;

                                if (canRotate)
                                    RotateShape(currentShape);
                            }
                            else
                            {
                                label8.BackColor = Color.Red;

                                RotateShape(currentShape);
                            }
                        }

                        display.Refresh();

                        label5.Text = tempShape.rotation.ToString();
                        rotationEnabled = false;
                    }

                }
                else
                    label1.BackColor = Color.Red;

                // DOWN
                if ((currentKeys & Tetris.KeyPress.Down) > 0)
                {
                    gameClock.Interval = levelSpeed[level - 1] / downSpeedUpConst;

                    label2.BackColor = Color.LightGreen;
                }
                else
                    label2.BackColor = Color.Red;

                // LEFT
                MoveLeft();

                // RIGHT
                MoveRight();

                if ((currentKeys & Tetris.KeyPress.Shift) > 0)
                    label10.BackColor = Color.LightGreen;
                else
                    label10.BackColor = Color.Red;

                label10.Text = CKString() + "\n\n" + shiftMovedLeft.ToString() + "\n" + shiftMovedRight.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gameClock_Tick(object sender, EventArgs e)
        {
            try
            {
                bool gameOver = false;

                for (int i = 0; i < gameW; i++)
                {
                    if (gameArea[0, i].visible)
                    {
                        gameOver = true;
                        break;
                    }
                }

                if (gameOver)
                {
                    EndGame();
                    panel_levelChoose.Enabled = true;
                    panel_levelChoose.Visible = true;
                }
                else
                {
                    if (currentShape.y < gameH - currentShape.h)
                    {
                        // y axis collison checking
                        int brickCount = 0;

                        for (int j = 0; j < currentShape.h; j++)
                            for (int i = 0; i < currentShape.w; i++)
                                if (gameArea[currentShape.y + currentShape.h - j, currentShape.x + i].visible)
                                    brickCount++;

                        if (brickCount == 0)
                            currentShape.y++;
                        else
                        {
                            bool canPass = true;

                            for (int j = 0; j < currentShape.h; j++)
                            {
                                for (int i = 0; i < currentShape.w; i++)
                                {
                                    if (currentShape.shape[currentShape.h - j - 1][i] && gameArea[currentShape.y + currentShape.h - j, currentShape.x + i].visible)
                                        canPass = false;
                                }
                            }

                            if (canPass)
                                currentShape.y++;
                            else
                                PieceLanded();
                        }
                    }
                    else
                        PieceLanded();

                    display.Refresh();

                    if (WaveOut.DeviceCount > 0 && musicPlayer.PlaybackState == PlaybackState.Stopped && !panel_levelChoose.Visible && !panel_highscore.Visible)
                        PlaySong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region FocusEvents
        private void Game_Activated(object sender, EventArgs e)
        {
            SetPause(true);
        }

        private void Game_Deactivate(object sender, EventArgs e)
        {
            SetPause(false);
        }
        #endregion

        #region ButtonEvents
        private void btn_start_Click(object sender, EventArgs e)
        {
            panel_levelChoose.Visible = false;
            panel_levelChoose.Enabled = false;

            level = Convert.ToInt32(num_levelChoose.Value);
            startingLevel = level;
            StartGame();
            StartGame();
        }

        private void pb_btn_info_Click(object sender, EventArgs e)
        {
            try
            {
                lb_controls.Visible = !lb_controls.Visible;

                if (!lb_controls.Visible && !lb_scoreboard.Visible)
                    SetPause(true);
                else if (lb_controls.Visible)
                    SetPause(false);

                if (lb_controls.Visible)
                    lb_controls.BringToFront();
                else
                    lb_controls.SendToBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_btn_scoreboard_Click(object sender, EventArgs e)
        {
            try
            {
                lb_scoreboard.Visible = !lb_scoreboard.Visible;

                if (!lb_controls.Visible && !lb_scoreboard.Visible)
                    SetPause(true);
                else if (lb_scoreboard.Visible)
                    SetPause(false);

                if (lb_scoreboard.Visible)
                    lb_scoreboard.BringToFront();
                else
                    lb_scoreboard.SendToBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tb_name.Text) && !String.IsNullOrWhiteSpace(tb_name.Text))
                {
                    if (String.IsNullOrEmpty(Properties.Settings.Default.scoreboard))
                    {
                        Properties.Settings.Default.scoreboard = tb_name.Text + " - " + score;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        List<string> scoreboard = new List<string>();
                        List<int> scores = new List<int>();

                        foreach (string s in Properties.Settings.Default.scoreboard.Split(';'))
                        {
                            scoreboard.Add(s);
                            scores.Add(Convert.ToInt32(s.Split('-')[1].Substring(1)));
                        }

                        foreach (int n in scores)
                        {
                            if (score > n)
                            {
                                scoreboard.Insert(scores.IndexOf(n), tb_name.Text + " - " + score);
                                break;
                            }
                            else if (score == n)
                            {
                                scoreboard.Insert(scores.IndexOf(n) + 1, tb_name.Text + " - " + score);
                                break;
                            }
                        }

                        string temp = String.Empty;

                        foreach (string s in scoreboard)
                            temp += s + ";";

                        temp = temp.Substring(0, temp.Length - 1);

                        Properties.Settings.Default.scoreboard = temp;
                        Properties.Settings.Default.Save();

                        UpdateScoreboard();

                        panel_levelChoose.Enabled = true;
                        panel_levelChoose.Visible = true;

                        panel_highscore.Enabled = false;
                        panel_highscore.Visible = false;

                        MessageBox.Show(temp);
                    }
                }
                else
                    MessageBox.Show("Please write your name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                DisplayScoreboardScores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}