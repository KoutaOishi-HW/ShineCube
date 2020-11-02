# ShineCube

URPでのBloomとEmissionを使用したオブジェクト発光プロジェクト
Universal Render Pipeline/Particles/Unlitを使用

Animationコンポーネントでも同様に可能
その際はコンポーネントのアクティブを切り替える

・明滅

![bloom2](https://user-images.githubusercontent.com/20298043/97674669-4307be00-1ad1-11eb-93d6-aaab68995daa.gif)

・白画面化

![7d8bad59e9fc29ca3d6b491c23fc693f](https://user-images.githubusercontent.com/20298043/97674004-1901cc00-1ad0-11eb-91e7-f757f2535fd4.gif)


※シェーダ毎にプロパティ名が異なるので注意。

※このUnlitシェーダはmat.SetColor( "_Emissive_Color", hoge ) )だが、例えばToonシェーダはmat.SetColor( "_Emissive_Color", hoge ) )にしないと動作しない。
