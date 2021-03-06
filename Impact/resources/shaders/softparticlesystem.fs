#version 110

/*

    Copyright (c) 2015 Oliver Lau <ola@ct.de>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

*/
uniform sampler2D uTexture;
uniform float uAge;
uniform float uMaxAge;

void main()
{
  float v = 1.0 - (uAge / uMaxAge);
  vec2 pos = gl_TexCoord[0].xy;
  gl_FragColor = texture2D(uTexture, pos) * vec4(v, 1.0, 1.0 - v, v);
}
