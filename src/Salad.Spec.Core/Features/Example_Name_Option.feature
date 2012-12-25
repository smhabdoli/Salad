Feature: --example option
    Use the --example (or -e) option to filter examples by name.

    The argument is compile to a .Net Regexp, and matched against the full
    description of example, which is the concatenation of descriptions of the
    group (including any nested groups) and the example.

    You can also use the optoin more than once to specify multiple example matches.

    Background:
        Given a file named "First_Spec.cs" with:
            """csharp
            describe("first group)
            {
                it("first example in first group) {}
                it("second example in first group) {}
            }
            """

        And a file named "Second_Spec.cs" with:
            """csharp
            describe("second group)
            {
                it("first example in second group) {}
                it("second example in second group) {}
            }
            """

        And a file named "Third_Spec.cs" with:
            """csharp
            describe("second group)
            {
                it("first example in third group) {}
                Context("nested group")
                {
                    it("first example in nested group) {}
                    it("second example in nested group) {}
                }
            }
            """

        And a file named "Fourth_Spec.cs" with:
            """csharp
            describe(Array)
            {
                describe("$Length")
                {
                    it("is the number of items")
                    {
                        Array.new([1,2,3]).Length.Should_eq(3);
                    }
                }
            }            
            """

    Scenario: no matches
        When I run `rspec . --example nothing_like_this`
        Then the examples should all pass

    Scenario: match on one word
        When I run `rspec . --example example`
        Then the examples should all pass

    Scenario: one match in each context
        When I run `rspec . --example 'first example'`
        Then the examples should all pass

    Scenario: one match in one file using just the example name
        When I run `rspec . --example 'first example in first group'`
        Then the examples should all pass

    Scenario: one match in one file using the example name and the group name
        When I run `rspec . --example 'first group first example in first group'`
        Then the examples should all pass

    Scenario: one match in one file using regexp
        When I run `rspec . --example 'first .* first example'`
        Then the examples should all pass

    Scenario: all examples in one group
        When I run `rspec . --example 'first group'`
        Then the examples should all pass

    Scenario: one match in one file with group name
        When I run `rspec . --example 'second group first example'`
        Then the examples should all pass

    Scenario: all examples in one group including examples in nested groups
        When I run `rspec . --example 'third group'`
        Then the examples should all pass

    Scenario: Object#method
        When I run `rspec . --example 'Array#length'`
        Then the examples should all pass
    
    Scenario: Multiple applications of example name option
        When I run `rspec . --example 'first group' --example 'second group' --format d`
        Then the examples should all pass
        And the output should contain all of these:
            |first example in first group|
            |second example in first group|
            |first example in second group|
            |second example in second group|
        And the output should not contain any of these:
            |first example in third group|
            |nested group first example in nested group|
            |nested group second example in nested group|
