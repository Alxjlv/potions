public static class CauldronFactory{

    public static Cauldron buildBigCauldron(){
        return new RealCauldron(10);
    }

    public static Cauldron buildSmallCauldron(){
        return new RealCauldron(3);
    }

    public static Cauldron buildTestCauldron(){
        return new TestCauldron(2);
    }

}