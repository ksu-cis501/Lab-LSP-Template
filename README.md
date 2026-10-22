# Lab: Identifying and Fixing an LSP Violation

**Team / Name:**

## Step 2 — The Violation

1. Why does `PaymentProcessor.PayBills()` fail when using `FixedTermDepositAccount`?

2. How is the Liskov Substitution Principle broken? Refer to the `Withdraw` contract, and state whether `FixedTermDepositAccount` strengthens a precondition or weakens a postcondition.

3. Where does the bug live: in `PaymentProcessor`, `BankAccount`, or `FixedTermDepositAccount`? Defend your answer.

4. After its maturity date, a `FixedTermDepositAccount` withdraws normally whenever `PayBills` has confirmed the balance is sufficient. Does that mean there is no LSP violation? Why or why not?

5. Both `PayBills` and `BankAccount.Withdraw` check whether the balance is sufficient. Is this duplication a mistake? Explain why each check is there.

## Explanation (10–15 sentences)

*Explain the original violation and how your redesign fixed it.*

## Step 4 — Reflection

1. How does the new design prevent future LSP violations?

2. What did you change about how classes relate to one another?

3. In what situations would you choose interfaces instead of inheritance?
