using NgpConverter;
using VerifyXunit;

namespace NgpTest
{
    public class NgpTest
    {
        [Fact]
        public Task Convert_Success()
        {
            // Act
            var pgns = Ngp.Convert(pgnStr);

            // Assert
            return Verifier.Verify(pgns);
        }

        #region Helpers
        private static readonly string pgnStr = @"[Event ""Saint Louis Rapid 2019""]
[Site ""Saint Louis USA""]
[Date ""2019.08.11""]
[Round ""4.1""]
[White ""Caruana, F.""]
[Black ""Carlsen, M.""]
[Result ""1-0""]
[GameId ""boLujJkB""]
[WhiteElo ""2818""]
[BlackElo ""2882""]
[Variant ""Standard""]
[TimeControl ""-""]
[ECO ""B30""]
[Opening ""Sicilian Defense: Nyezhmetdinov-Rossolimo Attack""]
[Termination ""Normal""]
[Annotator ""lichess.org""]

1. e4 { [%eval 0.24] } 1... c5 { [%eval 0.2] } 2. Nf3 { [%eval 0.21] } 2... Nc6 { [%eval 0.08] } 3. Bb5 { [%eval 0.13] } { B30 Sicilian Defense: Nyezhmetdinov-Rossolimo Attack } 3... e6 { [%eval 0.48] } 4. Bxc6 { [%eval 0.26] } 4... bxc6 { [%eval 0.25] } 5. d3 { [%eval 0.04] } 5... Ne7 { [%eval 0.02] } 6. b3 { [%eval 0.0] } 6... Ng6 { [%eval 0.35] } 7. h4 { [%eval 0.19] } 7... h5 { [%eval 0.47] } 8. e5 { [%eval 0.13] } 8... f6 { [%eval 0.17] } 9. Nbd2 { [%eval 0.37] } 9... d6 { [%eval 0.51] } 10. exd6 { [%eval 0.65] } 10... e5 { [%eval 0.58] } 11. Bb2 { [%eval 0.17] } 11... Bg4 { [%eval 0.49] } 12. Qe2 { [%eval 0.36] } 12... Qxd6 { [%eval 0.51] } 13. g3 { [%eval 0.1] } 13... Be7 { [%eval 0.58] } 14. O-O-O?! { (0.58 → -0.09) Inaccuracy. Qe4 was best. } { [%eval -0.09] } (14. Qe4 Nf8) 14... Nf8?! { (-0.09 → 0.87) Inaccuracy. Qd5 was best. } { [%eval 0.87] } (14... Qd5 15. Qe3) 15. Rde1 { [%eval 0.7] } 15... Ne6?! { (0.70 → 1.35) Inaccuracy. Qd5 was best. } { [%eval 1.35] } (15... Qd5 16. Qe3) 16. Qe4 { [%eval 1.4] } 16... Qd5 { [%eval 1.74] } 17. Nxe5 { [%eval 1.73] } 17... Qxe4 { [%eval 2.03] } 18. dxe4 { [%eval 1.94] } 18... fxe5 { [%eval 2.0] } 19. f3 { [%eval 1.84] } 19... Nd4 { [%eval 1.79] } 20. fxg4 { [%eval 2.06] } 20... hxg4 { [%eval 2.08] } 21. Nc4 { [%eval 1.94] } 21... O-O { [%eval 1.94] } 22. Kb1 { [%eval 1.51] } 22... Rf2 { [%eval 1.74] } 23. Nxe5 { [%eval 1.76] } 23... Nxc2 { [%eval 1.71] } 24. Nxg4 { [%eval 1.62] } 24... Rg2 { [%eval 2.0] } 25. Reg1 { [%eval 1.53] } 25... Re2 { [%eval 1.5] } 26. h5 { [%eval 1.14] } 26... c4? { (1.14 → 2.40) Mistake. Rxe4 was best. } { [%eval 2.4] } (26... Rxe4 27. Kxc2) 27. h6 { [%eval 2.25] } 27... c3?? { (2.25 → 5.09) Blunder. Na3+ was best. } { [%eval 5.09] } (27... Na3+ 28. Bxa3 Bxa3 29. h7+ Kh8 30. Ne5 g6 31. Nxg6+ Kg7 32. h8=Q+ Rxh8 33. Nxh8 c3 34. Rc1) 28. h7+ { [%eval 4.93] } 28... Kf7 { [%eval 4.71] } 29. Rf1+ { [%eval 3.81] } 29... Bf6? { (3.81 → 7.05) Mistake. Ke6 was best. } { [%eval 7.05] } (29... Ke6 30. Rf2 Na3+ 31. Bxa3 c2+ 32. Kb2 c1=R+ 33. Kxc1 Bxa3+ 34. Kd1 Rxf2 35. Nxf2 Rh8 36. Nd3) 30. Bc1 { [%eval 6.96] } 30... Nb4 { [%eval 7.22] } 31. e5 { [%eval 7.22] } 31... Rxa2 { [%eval 7.0] } 32. Ne3 { [%eval 6.64] } 32... Rh8 { [%eval 8.43] } 33. exf6 { [%eval 8.33] } 33... g5 { [%eval 8.23] } 34. Rd1 { [%eval 7.75] } 34... a5 { [%eval 10.53] } 35. Rd4 { [%eval 9.49] } 35... c2+ { [%eval 9.21] } 36. Nxc2 { [%eval 8.88] } 36... Rxc2 { [%eval 8.32] } 37. Rxb4 { [%eval 8.77] } 37... Rxc1+ { [%eval 8.76] } 38. Kxc1 { [%eval 8.31] } 38... axb4 { [%eval 7.9] } 39. Rh6 { [%eval 7.45] } { Black resigns. } 1-0

[Event ""Saint Louis Blitz 2019""]
[Site ""Saint Louis USA""]
[Date ""2019.08.14""]
[Round ""14.5""]
[White ""Caruana, F.""]
[Black ""Carlsen, M.""]
[Result ""1-0""]
[GameId ""Sxov6E94""]
[WhiteElo ""2818""]
[BlackElo ""2882""]
[Variant ""Standard""]
[TimeControl ""-""]
[ECO ""C63""]
[Opening ""Ruy Lopez: Schliemann Defense""]
[Termination ""Normal""]
[Annotator ""lichess.org""]

1. e4 { [%eval 0.24] } 1... e5 { [%eval 0.37] } 2. Nf3 { [%eval 0.26] } 2... Nc6 { [%eval 0.15] } 3. Bb5 { [%eval 0.43] } 3... f5 { [%eval 0.72] } { C63 Ruy Lopez: Schliemann Defense } 4. d3 { [%eval 0.53] } 4... fxe4 { [%eval 0.26] } 5. dxe4 { [%eval 0.45] } 5... Nf6 { [%eval 0.49] } 6. O-O { [%eval 0.47] } 6... d6 { [%eval 0.56] } 7. Bc4 { [%eval 0.59] } 7... Bg4 { [%eval 0.71] } 8. h3 { [%eval 0.58] } 8... Bh5 { [%eval 0.53] } 9. Nc3 { [%eval 0.62] } 9... Qd7 { [%eval 0.62] } 10. Be3 { [%eval 0.75] } 10... Be7 { [%eval 0.7] } 11. a4 { [%eval 0.55] } 11... Rf8 { [%eval 1.1] } 12. Be2 { [%eval 0.91] } 12... Bxf3 { [%eval 1.3] } 13. Bxf3 { [%eval 1.48] } 13... Kf7 { [%eval 1.52] } 14. Nd5 { [%eval 1.28] } 14... Kg8 { [%eval 1.38] } 15. a5 { [%eval 1.3] } 15... a6 { [%eval 1.41] } 16. c3 { [%eval 1.22] } 16... Kh8 { [%eval 1.23] } 17. Qb3 { [%eval 1.45] } 17... Nd8 { [%eval 1.74] } 18. Rad1 { [%eval 1.17] } 18... Nxd5 { [%eval 1.17] } 19. Bg4 { [%eval 0.88] } 19... Qb5 { [%eval 0.79] } 20. Qxd5 { [%eval 0.88] } 20... Qxb2?! { (0.88 → 1.95) Inaccuracy. Qxd5 was best. } { [%eval 1.95] } (20... Qxd5 21. Rxd5) 21. Qc4 { [%eval 1.91] } 21... c6 { [%eval 1.96] } 22. Rb1 { [%eval 2.18] } 22... Qa3 { [%eval 2.06] } 23. Bb6 { [%eval 1.92] } 23... Nf7?! { (1.92 → 2.59) Inaccuracy. Rf4 was best. } { [%eval 2.59] } (23... Rf4 24. Qd3) 24. Ra1 { [%eval 2.32] } 24... Qb2 { [%eval 2.2] } 25. Rfb1 { [%eval 2.07] } 25... d5?? { (2.07 → 6.18) Blunder. Qc2 was best. } { [%eval 6.18] } (25... Qc2 26. Rc1 Qd2 27. Be3 d5 28. Qb3 Qd3 29. exd5 Qxd5 30. Qxb7 Bg5 31. Rd1 Qc4 32. Qb6) 26. Qd3 { [%eval 5.99] } 26... dxe4 { [%eval 6.09] } 27. Qd7 { [%eval 5.91] } 27... Qxc3 { [%eval 6.01] } 28. Qxe7 { [%eval 5.71] } 28... Nh6 { [%eval 5.68] } 29. Be3 { [%eval 5.81] } 29... Rf7 { [%eval 6.52] } 30. Qe6 { [%eval 6.35] } 30... Raf8 { [%eval 6.48] } 31. Ra2 { [%eval 5.58] } 31... Nxg4 { [%eval 5.34] } 32. hxg4?! { (5.34 → 3.74) Inaccuracy. Qxg4 was best. } { [%eval 3.74] } (32. Qxg4) 32... Qd3 { [%eval 3.74] } 33. Qb3 { [%eval 3.74] } 33... Qd7?! { (3.74 → 5.64) Inaccuracy. Qxb3 was best. } { [%eval 5.64] } (33... Qxb3 34. Rxb3) 34. Qd1?! { (5.64 → 4.13) Inaccuracy. Rd2 was best. } { [%eval 4.13] } (34. Rd2) 34... Qe6?! { (4.13 → 5.47) Inaccuracy. Qd8 was best. } { [%eval 5.47] } (34... Qd8) 35. Rd2 { [%eval 5.22] } 35... h6 { [%eval 5.98] } 36. Rbb2 { [%eval 5.05] } 36... Kh7 { [%eval 5.51] } 37. Rd6 { [%eval 5.48] } 37... Qe7 { [%eval 6.3] } 38. g5 { [%eval 6.29] } 38... hxg5 { [%eval 6.22] } 39. Rbd2 { [%eval 6.07] } 39... Kg8 { [%eval 6.25] } 40. Qg4 { [%eval 5.73] } 40... Qc7?! { (5.73 → 9.03) Inaccuracy. Rf4 was best. } { [%eval 9.03] } (40... Rf4 41. Rd7) 41. Bb6? { (9.03 → 4.52) Mistake. Rd7 was best. } { [%eval 4.52] } (41. Rd7) 41... Qe7?! { (4.52 → 6.88) Inaccuracy. Qc8 was best. } { [%eval 6.88] } (41... Qc8) 42. Be3 { [%eval 5.55] } 42... Qc7?! { (5.55 → 8.89) Inaccuracy. Rf4 was best. } { [%eval 8.89] } (42... Rf4 43. Rd7) 43. Rd7 { [%eval 8.42] } 43... Qc8 { [%eval 8.49] } 44. Qe6 { [%eval 8.11] } 44... c5 { [%eval 10.14] } 45. Qc4 { [%eval 7.72] } 45... Qe8 { [%eval 7.59] } 46. Rxb7 { [%eval 7.47] } 46... Kh7 { [%eval 7.22] } 47. Rxf7 { [%eval 6.92] } 47... Rxf7 { [%eval 7.91] } 48. Qxa6 { [%eval 7.64] } 48... Qa4 { [%eval 9.67] } 49. Qe6 { [%eval 9.27] } 49... Qa1+ { [%eval 9.43] } 50. Kh2 { [%eval 9.25] } 50... Rf6 { [%eval 8.93] } 51. Qg4 { [%eval 8.53] } 51... Qxa5 { [%eval 12.3] } 52. Qxe4+ { [%eval 10.52] } 52... Kh6?! { (10.52 → Mate in 6) Checkmate is now unavoidable. Kg8 was best. } { [%eval #6] } (52... Kg8 53. Bxg5) 53. Qh4+ { [%eval #10] } 53... Kg6 { [%eval #10] } 54. Qxg5+ { [%eval #9] } 54... Kh7 { [%eval #4] } 55. Qh5+?! { (Mate in 4 → 60.21) Lost forced checkmate sequence. Rd7 was best. } { [%eval 60.21] } (55. Rd7 Rg6 56. Qh5+ Kg8 57. Qxg6 Kf8 58. Qf7#) 55... Kg8 { [%eval 59.3] } 56. Qe8+ { [%eval 23.46] } 56... Kh7 { [%eval 17.73] } 57. Rd8 { [%eval 14.46] } 57... Rf5?! { (14.46 → Mate in 9) Checkmate is now unavoidable. Qxd8 was best. } { [%eval #9] } (57... Qxd8) 58. Qg8+ { [%eval #8] } 58... Kg6 { [%eval #8] } 59. Rd6+ { [%eval #8] } 59... Rf6 { [%eval #8] } 60. Qe8+ { [%eval #7] } 60... Kf5 { [%eval #3] } 61. Qh5+ { [%eval #3] } 61... Ke4 { [%eval #3] } 62. Qg4+ { [%eval #2] } { Black resigns. } 1-0


[Event ""7th Sinquefield Cup 2019""]
[Site ""Saint Louis USA""]
[Date ""2019.08.19""]
[Round ""3.2""]
[White ""Carlsen, M.""]
[Black ""Caruana, F.""]
[Result ""1/2-1/2""]
[GameId ""QR5UbqUY""]
[WhiteElo ""2882""]
[BlackElo ""2818""]
[Variant ""Standard""]
[TimeControl ""-""]
[ECO ""D24""]
[Opening ""Queen's Gambit Accepted""]
[Termination ""Normal""]
[Annotator ""lichess.org""]

1. d4 { [%eval 0.25] } 1... Nf6 { [%eval 0.22] } 2. c4 { [%eval 0.18] } 2... e6 { [%eval 0.23] } 3. Nf3 { [%eval 0.12] } 3... d5 { [%eval 0.23] } 4. Nc3 { [%eval 0.14] } 4... dxc4 { [%eval 0.04] } 5. e4 { [%eval 0.09] } { D24 Queen's Gambit Accepted } 5... Bb4 { [%eval 0.28] } 6. Bxc4 { [%eval 0.0] } 6... Nxe4 { [%eval 0.23] } 7. O-O { [%eval 0.0] } 7... Nf6 { [%eval 0.26] } 8. Qa4+ { [%eval 0.3] } 8... Nc6 { [%eval 0.3] } 9. Ne5 { [%eval 0.39] } 9... Bd6 { [%eval 0.34] } 10. Nxc6 { [%eval 0.44] } 10... bxc6 { [%eval 0.3] } 11. Qxc6+ { [%eval 0.36] } 11... Bd7 { [%eval 0.3] } 12. Qf3 { [%eval 0.51] } 12... O-O { [%eval 0.53] } 13. Bg5 { [%eval 0.41] } 13... h6 { [%eval 0.61] } 14. Bh4 { [%eval 0.49] } 14... Rb8 { [%eval 0.56] } 15. b3 { [%eval 0.52] } 15... Rb6 { [%eval 0.53] } 16. Ne4 { [%eval 0.44] } 16... Be7 { [%eval 0.43] } 17. Nxf6+ { [%eval 0.5] } 17... Bxf6 { [%eval 0.58] } 18. Bxf6 { [%eval 0.57] } 18... Qxf6 { [%eval 0.54] } 19. Qxf6 { [%eval 0.66] } 19... gxf6 { [%eval 0.53] } 20. d5 { [%eval 0.48] } 20... e5 { [%eval 0.52] } 21. Rfc1 { [%eval 0.08] } 21... a5 { [%eval 0.46] } 22. Be2 { [%eval 0.13] } 22... c6 { [%eval 0.44] } 23. dxc6 { [%eval 0.32] } 23... Rxc6 { [%eval 0.58] } 24. Rxc6 { [%eval 0.56] } 24... Bxc6 { [%eval 0.51] } 25. Rc1 { [%eval 0.46] } 25... Bd7 { [%eval 0.48] } 26. Rc5 { [%eval 0.31] } 26... Ra8 { [%eval 0.8] } 27. f4 { [%eval 0.27] } 27... exf4 { [%eval 0.32] } 28. Bf3 { [%eval 0.31] } 28... Ra6 { [%eval 0.22] } 29. Kf2 { [%eval 0.0] } 29... Be6 { [%eval 0.0] } 30. Be2 { [%eval 0.0] } 30... Ra8 { [%eval 0.0] } 31. Bf3 { [%eval 0.19] } 31... Ra6 { [%eval 0.23] } 32. Bb7 { [%eval 0.0] } 32... Ra7 { [%eval 0.0] } 33. Be4 { [%eval 0.0] } 33... Kg7 { [%eval 0.0] } 34. Kf3 { [%eval 0.0] } 34... a4 { [%eval 0.0] } 35. Bc2 { [%eval -0.19] } 35... axb3 { [%eval -0.17] } 36. Bxb3 { [%eval -0.13] } 36... Rb7 { [%eval -0.13] } 37. Kxf4 { [%eval -0.17] } 37... Bxb3 { [%eval -0.13] } 38. axb3 { [%eval -0.13] } 38... Rxb3 { [%eval 0.0] } 39. g3 { [%eval 0.0] } 39... Rb4+ { [%eval 0.0] } 40. Kf3 { [%eval 0.0] } 40... Rb3+ { [%eval -0.03] } 41. Kf4 { [%eval -0.03] } 41... Rb4+ { [%eval -0.13] } 42. Kf3 { [%eval -0.13] } 42... Rb3+ { [%eval 0.0] } 43. Kf4 { [%eval -0.13] } { The game is a draw. } 1/2-1/2


[Event ""Chessable Masters Final""]
[Site ""chess24.com INT""]
[Date ""2020.06.27""]
[Round ""1.23""]
[White ""Caruana, Fabiano""]
[Black ""Carlsen, Magnus""]
[Result ""0-1""]
[GameId ""cOKsoa1P""]
[WhiteElo ""2835""]
[BlackElo ""2863""]
[Variant ""Standard""]
[TimeControl ""-""]
[ECO ""E25""]
[Opening ""Nimzo-Indian Defense: Sämisch Variation, Keres Variation""]
[Termination ""Normal""]
[Annotator ""lichess.org""]

1. d4 { [%eval 0.0] } 1... Nf6 { [%eval 0.2] } 2. c4 { [%eval 0.23] } 2... e6 { [%eval 0.28] } 3. Nc3 { [%eval 0.0] } 3... Bb4 { [%eval 0.25] } 4. f3 { [%eval 0.0] } 4... d5 { [%eval 0.25] } 5. a3 { [%eval 0.13] } 5... Bxc3+ { [%eval 0.0] } 6. bxc3 { [%eval 0.0] } 6... c5 { [%eval 0.11] } 7. cxd5 { [%eval 0.12] } 7... Nxd5 { [%eval 0.21] } 8. dxc5 { [%eval 0.27] } { E25 Nimzo-Indian Defense: Sämisch Variation, Keres Variation } 8... Qa5 { [%eval 0.05] } 9. e4 { [%eval 0.49] } 9... Nf6 { [%eval 0.54] } 10. Be3 { [%eval 0.52] } 10... O-O { [%eval 0.29] } 11. a4 { [%eval 0.29] } 11... Nfd7 { [%eval 0.33] } 12. Kf2 { [%eval 0.35] } 12... Nxc5 { [%eval 0.18] } 13. Qd6 { [%eval 0.16] } 13... b6 { [%eval 0.43] } 14. Bb5 { [%eval 0.25] } 14... Bd7? { (0.25 → 1.40) Mistake. Qxc3 was best. } { [%eval 1.4] } (14... Qxc3 15. Ne2) 15. Ne2 { [%eval 1.37] } 15... Bxb5?! { (1.37 → 2.39) Inaccuracy. a6 was best. } { [%eval 2.39] } (15... a6 16. Bxc5) 16. Bxc5 { [%eval 2.23] } 16... bxc5 { [%eval 2.11] } 17. Qxc5 { [%eval 2.13] } 17... Nd7 { [%eval 2.22] } 18. Qxb5?? { (2.22 → -0.37) Blunder. axb5 was best. } { [%eval -0.37] } (18. axb5 Qd8 19. Qd6 Qc8 20. c4 Nc5 21. Rhd1 Nb3 22. Ra4 Nc5 23. Ra3 a6 24. Qc6 axb5) 18... Qc7 { [%eval -0.26] } 19. Rhd1 { [%eval -0.42] } 19... Ne5?! { (-0.42 → 0.37) Inaccuracy. Rfd8 was best. } { [%eval 0.37] } (19... Rfd8 20. Rd4) 20. f4 { [%eval 0.16] } 20... Ng4+ { [%eval 0.19] } 21. Kf3 { [%eval 0.21] } 21... Nf6 { [%eval 0.39] } 22. Qe5 { [%eval 0.36] } 22... Qe7 { [%eval 0.16] } 23. Rd4 { [%eval 0.08] } 23... Rac8 { [%eval 0.49] } 24. Rb1 { [%eval 0.2] } 24... Rfd8 { [%eval 0.59] } 25. Rxd8+?! { (0.59 → 0.00) Inaccuracy. Rbd1 was best. } { [%eval 0.0] } (25. Rbd1) 25... Qxd8 { [%eval 0.08] } 26. Qd4 { [%eval 0.07] } 26... Qc7 { [%eval 0.0] } 27. Rd1 { [%eval 0.0] } 27... h6 { [%eval 0.0] } 28. g4 { [%eval 0.05] } 28... Re8 { [%eval 0.1] } 29. Qd6 { [%eval 0.0] } 29... Qc4 { [%eval 0.5] } 30. Qb4 { [%eval 0.0] } 30... Qc8 { [%eval 0.01] } 31. Ng3 { [%eval -0.06] } 31... e5 { [%eval -0.95] } 32. f5 { [%eval 0.0] } 32... Rd8 { [%eval 0.0] } 33. Rxd8+ { [%eval -0.79] } 33... Qxd8 { [%eval -0.09] } 34. Ke2?! { (-0.09 → -0.77) Inaccuracy. Qb1 was best. } { [%eval -0.77] } (34. Qb1 Qd2) 34... Nxg4 { [%eval -0.99] } 35. Nf1?! { (-0.99 → -1.99) Inaccuracy. h3 was best. } { [%eval -1.99] } (35. h3 Nf6 36. Qc5 Qb8 37. Qb4 Qc8 38. Kd3 Kh7 39. a5 Qa6+ 40. Ke3 h5 41. Qc5 h4) 35... a5 { [%eval -1.76] } 36. Qb5?! { (-1.76 → -2.41) Inaccuracy. Qb1 was best. } { [%eval -2.41] } (36. Qb1 Qg5 37. Qd3 Nxh2 38. Nxh2 Qg2+ 39. Ke1 Qxh2 40. Qd7 Qg3+ 41. Ke2 Qg4+ 42. Ke3 f6) 36... Qh4 { [%eval -2.1] } 37. Nd2? { (-2.10 → -3.94) Mistake. Kd1 was best. } { [%eval -3.94] } (37. Kd1 Kh7) 37... Qxh2+ { [%eval -3.71] } 38. Kd3 { [%eval -3.82] } 38... Qg3+ { [%eval -3.86] } 39. Kc2 { [%eval -4.32] } 39... Ne3+ { [%eval -4.54] } 40. Kb3 { [%eval -5.55] } 40... Qe1 { [%eval -5.78] } 41. Qd3 { [%eval -5.79] } 41... Qd1+ { [%eval -5.26] } 42. Ka2 { [%eval -5.34] } 42... Qxa4+ { [%eval -5.96] } 43. Kb2 { [%eval -5.78] } 43... Ng4 { [%eval -5.58] } 44. Nb3 { [%eval -6.0] } 44... Nf6 { [%eval -6.05] } 45. Nc5 { [%eval -6.2] } 45... Qc6 { [%eval -6.82] } 46. Qd8+ { [%eval -6.85] } 46... Kh7 { [%eval -6.92] } 47. Qe7 { [%eval -6.93] } 47... Qb5+ { [%eval -7.08] } 48. Kc2 { [%eval -8.48] } 48... a4 { [%eval -8.04] } 49. Qxe5 { [%eval -8.38] } 49... a3 { [%eval -8.15] } 50. Nd3 { [%eval -9.21] } 50... Qa4+ { [%eval -9.22] } { White resigns. } 0-1



";
        #endregion
    }
}