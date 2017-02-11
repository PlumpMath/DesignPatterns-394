public abstract class Builder {
    /*
    *   Building each part of a product.
    *   Type of product depends on the Builder required.
    */
    public abstract void BuildPart1( Product product );
    public abstract void BuildPart2( Product product );
}

public class ConcreteBuilderA : Builder {
    public override void BuildPart1( Product product ) {
        product.AddPart("Part1");
    }
    public override void BuildPart2( Product product ) {
        product.AddPart("Part2");
    }
}

public class ConcreteBuilderB : Builder {
    public override void BuildPart1( Product product ) {
        product.AddPart("Part1");
    }
    public override void BuildPart2( Product product ) {
        product.AddPart("Part2");
    }
}
