void BlinnPhongLighting_half(half3 Specular, half Smoothness, half3 Direction, half3 Color, half3 WorldNormal, half3 WorldView, out half3 Out)
{
    // Normalizar todas las direcciones
    Direction = normalize(Direction);
    WorldNormal = normalize(WorldNormal);
    WorldView = normalize(WorldView);

    // Calcular el vector medio entre la luz y la vista (Blinn-Phong)
    half3 halfVector = normalize(Direction + WorldView);

    // Cálculo del specular usando el ángulo entre la normal y el halfVector
    half specAngle = saturate(dot(WorldNormal, halfVector));

    // Aplicar la suavidad para ajustar el brillo especular
    half specularStrength = pow(specAngle, Smoothness);

    // Multiplicar por el color de la luz y la intensidad de specular
    Out = Specular * Color * specularStrength;
}
