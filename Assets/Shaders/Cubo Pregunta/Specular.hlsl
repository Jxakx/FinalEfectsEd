void ComputeBlinnPhong_half(half3 lightDir, half3 normal, half3 viewDir, half attenuation, half shininess, out half Specular)
{
    half3 reflectedLightDir = reflect(-lightDir, normal);
    half specularDot = saturate(dot(viewDir, reflectedLightDir));
    
    Specular = pow(specularDot, shininess) * attenuation;
}
