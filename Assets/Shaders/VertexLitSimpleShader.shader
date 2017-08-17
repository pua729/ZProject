Shader "Custom/VertexLitSimple" {
    Properties {
        _Color ("Main Color", COLOR) = (1,1,1,1)
    }
    SubShader {
        Pass {
            Material {
                // 拡散色
                Diffuse [_Color]
                // 環境光
                Ambient [_Color]
            }
            Lighting On
        }
    }
} 
