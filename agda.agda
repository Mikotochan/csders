open import Agda.Primitive
open import Data.Nat using (ℕ)


data ∑ {n₁ : Level} {n₂ : Level} (A : Set n₁) (P : A → Set n₂) : Set (n₁ ⊔ n₂) where
  sum : (a : A) → (pa : P a) → ∑ A P

data List {n : Level} (t : Set n) : Set n where
  _::_ : t → List t → List t
  []   : List t

data Unit {n : Level} : Set n where
  ##   : Unit

heterohomo : List (∑ Set λ x → x)
heterohomo = (sum ℕ 0) :: ((sum (List Unit) (## :: [])) :: ((sum Unit ##) :: []))
