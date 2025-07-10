using Ngp;
using VerifyXunit;

namespace NgpTest
{
    public class NgpTest
    {
        [Fact]
        public Task Convert_Success()
        {
            // Act
            var pgns = Pgn.Convert(pgnStr);

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


";
        #endregion
    }
}